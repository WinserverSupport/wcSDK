//***********************************************************************
// wcio.c -- Wildcat! door I/O wrappers for wcZork (wcDoor32)
//
// 500.4  26.11.26  rewrite: EOF on offline/idle, CR/LF and CR/NUL
//                  pairs, backspace, ANSI keys skipped, len honored and
//                  line terminated, \r\n for every \n, sized printf,
//                  wcioInit/wcioShutdown/wcioSetIdle
// 500.4  26.11.26  read queued bytes before waiting (input lag: the
//                  pipe event fires once per write, not per byte);
//                  per-user save file; /record, /replay, /replaydelay
// 500.4  26.11.26  ANSI colors: prompt, typed input; /nocolor
// 500.4  26.11.26  wcioAutoSaveFile; wcioHelp (/? -h)
//***********************************************************************

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <io.h>
#include <fcntl.h>
#include <windows.h>
#include <stdarg.h>

#define USE_WCIO

#ifdef USE_WCIO
#   include <wcserver.h>
#   include <wclinker.h>
#   include <wcdoor32.h>
#   ifdef _WIN64                                // 500.4 26.11.26 wc10 x64 lib
#       pragma comment(lib,"wcdoor32x64.lib")
#   else
#       pragma comment(lib,"wcdoor32.lib")
#   endif
#endif  // USE_WCIO

#include "wcio.h"

int EchoEnabled     = 1;

static int DoorOpen    = 0;     // wcDoorInitialize succeeded
static int Offline     = 0;     // caller gone or idle timeout: input is EOF
static int PendingCR   = 0;     // last key was CR: drop a following LF/NUL
static int IdleTimeout = 300;   // seconds without a key before the warning
static const int IdleGrace = 60; // seconds after the warning

static DWORD UserId = 0;
static char  UserName[64] = "";
static char  DoorDir[MAX_PATH] = "";    // folder of wcZork.exe

static FILE *RecKeys    = NULL; // /record: raw bytes
static FILE *RecText    = NULL; // /record: readable twin
static DWORD RecStart   = 0;
static FILE *ReplayFile = NULL; // /replay:file
static DWORD ReplayDelay = 0;   // /replaydelay:N ms

static int UseColor = 1;        // /nocolor turns it off
#define COLOR_PROMPT "\x1b[1;33m"   // bright yellow
#define COLOR_INPUT  "\x1b[1;36m"   // bright cyan
#define COLOR_TEXT   "\x1b[0m"      // game text: terminal default

//---------------------------------------------------------------------
// raw output
//---------------------------------------------------------------------

static void DoorWrite(const char *s, int n)
{
#ifdef USE_WCIO
    if (DoorOpen && !Offline && n > 0) wcDoorWrite(s, n);
#else
    fwrite(s, 1, n, stdout);
#endif
}

// write s, every \n not already preceded by \r sent as \r\n
static void WriteText(const char *s, int n)
{
    int start = 0;
    for (int i = 0; i < n; i++) {
        if (s[i] == '\n' && (i == 0 || s[i-1] != '\r')) {
            DoorWrite(s + start, i - start);
            DoorWrite("\r\n", 2);
            start = i + 1;
        }
    }
    DoorWrite(s + start, n - start);
}

//---------------------------------------------------------------------
// record / replay
//---------------------------------------------------------------------

static void RecordEvent(const char *what)
{
    if (RecText) {
        fprintf(RecText, "+%8lu  --  %s\n", GetTickCount() - RecStart, what);
        fflush(RecText);
    }
}

static void RecordByte(BYTE c, int replayed)
{
    if (!RecKeys) return;
    fputc(c, RecKeys);
    fflush(RecKeys);

    char name[16];
    switch (c) {
    case 0:   strcpy(name, "NUL"); break;
    case 8:   strcpy(name, "BS");  break;
    case 9:   strcpy(name, "TAB"); break;
    case 10:  strcpy(name, "LF");  break;
    case 13:  strcpy(name, "CR");  break;
    case 27:  strcpy(name, "ESC"); break;
    case 127: strcpy(name, "DEL"); break;
    default:
        if (c < 32) sprintf(name, "^%c", c + '@');
        else        sprintf(name, "'%c'", c);
        break;
    }
    fprintf(RecText, "+%8lu  %02X  %s%s\n", GetTickCount() - RecStart, c,
            name, replayed ? "  (replay)" : "");
    fflush(RecText);
}

static void StartRecord()
{
    char dir[MAX_PATH];
    char base[MAX_PATH];
    char fn[MAX_PATH];
    SYSTEMTIME st;

    GetLocalTime(&st);
    _snprintf(dir, sizeof(dir), "%s\\logs", DoorDir);
    dir[sizeof(dir) - 1] = '\0';
    CreateDirectory(dir, NULL);
    _snprintf(base, sizeof(base), "%s\\zork-%lu-%02d%02d%02d-%02d%02d%02d",
              dir, UserId, st.wYear % 100, st.wMonth, st.wDay,
              st.wHour, st.wMinute, st.wSecond);
    base[sizeof(base) - 1] = '\0';

    _snprintf(fn, sizeof(fn), "%s.keys", base);
    fn[sizeof(fn) - 1] = '\0';
    RecKeys = fopen(fn, "wb");
    _snprintf(fn, sizeof(fn), "%s.txt", base);
    fn[sizeof(fn) - 1] = '\0';
    RecText = fopen(fn, "w");
    if (!RecKeys || !RecText) {
        if (RecKeys) fclose(RecKeys);
        if (RecText) fclose(RecText);
        RecKeys = RecText = NULL;
        return;
    }
    RecStart = GetTickCount();
    fprintf(RecText, "wcZork key record: user %lu (%s) node %lu\n",
            UserId, UserName, GetNode());
    fprintf(RecText, "+ms since start, hex, key\n");
    fflush(RecText);
}

//---------------------------------------------------------------------
// session
//---------------------------------------------------------------------

static const char *SwitchValue(const char *arg, const char *name)
{
    size_t n = strlen(name);
    if ((arg[0] == '/' || arg[0] == '-') && _strnicmp(arg + 1, name, n) == 0) {
        const char *v = arg + 1 + n;
        if (*v == '\0') return v;                 // bare switch
        if (*v == ':' || *v == '=') return v + 1;
    }
    return NULL;
}

// /? -? /h -h --help: switch help on the console (stdout), no door
// session needed.  Returns 1 when help was shown.
int wcioHelp(int argc, char **argv)
{
    int i;
    for (i = 1; i < argc; i++) {
        const char *a = argv[i];
        if (strcmp(a, "/?") == 0 || strcmp(a, "-?") == 0 ||
            _stricmp(a, "/h") == 0 || _stricmp(a, "-h") == 0 ||
            _stricmp(a, "--help") == 0) {
            printf("wcZork -- Dungeon (Zork I) door for Wildcat!\n\n");
            printf("usage: wcZork.exe [switches]\n");
            printf("  run as a Wildcat! door (wcDoor32); see batch\\wcZork.bat\n\n");
            printf("  /idle:N          idle timeout in seconds (default 300), then a\n");
            printf("                   60 second warning; the game is auto-saved\n");
            printf("  /nocolor         no ANSI colors (prompt, typed input)\n");
            printf("  /record          log every key to logs\\zork-<userid>-<date-time>.keys\n");
            printf("                   plus a readable .txt (timing, hex, key name)\n");
            printf("  /replay:file     feed a .keys file as input, then the keyboard\n");
            printf("  /replaydelay:N   ms between replayed keys (default 0)\n");
            printf("  /? -? /h -h      this help\n\n");
            printf("files, in the folder of wcZork.exe:\n");
            printf("  dtextc.dat                   game text (required)\n");
            printf("  saves\\zork-<userid>.dat      SAVE / RESTORE\n");
            printf("  saves\\zork-<userid>-auto.dat auto-save on quit, hang-up or idle;\n");
            printf("                               offered at the next start\n");
            return 1;
        }
    }
    return 0;
}

int wcioInit(int argc, char **argv)
{
    char *p;
    int i;

    GetModuleFileName(NULL, DoorDir, sizeof(DoorDir));
    p = strrchr(DoorDir, '\\');
    if (p) *p = '\0';

#ifdef USE_WCIO
    if (!wcDoorInitialize()) return 0;
    TwcNodeInfo ni;
    if (GetNodeInfo(GetNode(), ni)) {
        UserId = ni.User.Id;
        strncpy(UserName, ni.User.Name, sizeof(UserName) - 1);
    }
#endif
    DoorOpen = 1;

    int record = 0;
    for (i = 1; i < argc; i++) {
        const char *v;
        if ((v = SwitchValue(argv[i], "idle")) != NULL)        wcioSetIdle(atoi(v));
        else if ((v = SwitchValue(argv[i], "replaydelay")) != NULL) ReplayDelay = atoi(v);
        else if ((v = SwitchValue(argv[i], "replay")) != NULL && *v) ReplayFile = fopen(v, "rb");
        else if (SwitchValue(argv[i], "record") != NULL)       record = 1;
        else if (SwitchValue(argv[i], "nocolor") != NULL)      UseColor = 0;
    }
    if (record) StartRecord();
    return 1;
}

void wcioShutdown()
{
    RecordEvent("SHUTDOWN");
    if (RecKeys) fclose(RecKeys);
    if (RecText) fclose(RecText);
    RecKeys = RecText = NULL;
    if (ReplayFile) fclose(ReplayFile);
    ReplayFile = NULL;
#ifdef USE_WCIO
    if (DoorOpen) wcDoorShutdown();
#endif
    DoorOpen = 0;
}

void wcioSetIdle(int seconds)
{
    if (seconds > 0) IdleTimeout = seconds;
}

DWORD wcioUserId()
{
    return UserId;
}

const char *wcioUserName()
{
    return UserName;
}

// <door dir>\saves\zork-<userid>.dat; "dsave.dat" when there is no user
const char *wcioSaveFile(int forwrite)
{
    static char fn[MAX_PATH];
    if (UserId == 0) return "dsave.dat";
    _snprintf(fn, sizeof(fn), "%s\\saves", DoorDir);
    fn[sizeof(fn) - 1] = '\0';
    if (forwrite) CreateDirectory(fn, NULL);
    _snprintf(fn, sizeof(fn), "%s\\saves\\zork-%lu.dat", DoorDir, UserId);
    fn[sizeof(fn) - 1] = '\0';
    return fn;
}

// <door dir>\saves\zork-<userid>-auto.dat; NULL when there is no user
const char *wcioAutoSaveFile(int forwrite)
{
    static char fn[MAX_PATH];
    if (UserId == 0) return NULL;
    _snprintf(fn, sizeof(fn), "%s\\saves", DoorDir);
    fn[sizeof(fn) - 1] = '\0';
    if (forwrite) CreateDirectory(fn, NULL);
    _snprintf(fn, sizeof(fn), "%s\\saves\\zork-%lu-auto.dat", DoorDir, UserId);
    fn[sizeof(fn) - 1] = '\0';
    return fn;
}

static void SetColor(const char *ansi)
{
    if (UseColor) DoorWrite(ansi, (int)strlen(ansi));
}

// Input prompt in the prompt color; the line typed after it is echoed
// in the input color by wcfgets
void wcioPrompt(const char *s)
{
    SetColor(COLOR_PROMPT);
    WriteText(s, (int)strlen(s));
    SetColor(COLOR_TEXT);
}

//---------------------------------------------------------------------
// input
//---------------------------------------------------------------------

// Next raw byte: replay file first, then the door pipe.  Bytes already
// queued are read without waiting -- the pipe event fires once per
// write, so waiting first left the rest of a CR/LF pair, a paste or an
// ANSI sequence behind until the next key.  EOF when the caller is gone
// or idle timed out.
static int RawKey()
{
    if (ReplayFile) {
        int c = fgetc(ReplayFile);
        if (c != EOF) {
            if (ReplayDelay) Sleep(ReplayDelay);
            RecordByte((BYTE)c, 1);
            return c;
        }
        fclose(ReplayFile);
        ReplayFile = NULL;
        RecordEvent("REPLAY-END");
    }
#ifdef USE_WCIO
    int warned = 0;
    while (!Offline) {
        if (wcDoorCharReady() > 0) {
            BYTE c;
            if (wcDoorRead(&c, 1) == 1) {
                RecordByte(c, 0);
                return c;
            }
        }
        DWORD ms = (warned ? IdleGrace : IdleTimeout) * 1000;
        switch (wcDoorEvent(ms)) {

        case WCDOOR_EVENT_KEYBOARD:
            break;                  // read at the top of the loop

        case WCDOOR_EVENT_TIMEOUT:
            if (!warned) {
                warned = 1;
                RecordEvent("IDLE-WARN");
                wcprintf("\n** IDLE TIMEOUT IN %d SECONDS **\n", IdleGrace);
            } else {
                RecordEvent("IDLE-TIMEOUT");
                wcprintf("\n** IDLE TIMEOUT - GOODBYE **\n");
                Offline = 1;
            }
            break;

        case WCDOOR_EVENT_OFFLINE:
        case WCDOOR_EVENT_FAILED:
        default:
            RecordEvent("OFFLINE");
            Offline = 1;
            break;
        }
    }
    return EOF;
#else
    return getchar();
#endif
}

// Read one key.  CR is returned as '\n'; the LF or NUL a terminal sends
// after CR is dropped.
int wcgetchar()
{
    for (;;) {
        int c = RawKey();
        if (c == EOF) return EOF;
        if (PendingCR) {
            PendingCR = 0;
            if (c == 10 || c == 0) continue;
        }
        if (c == 13) {
            PendingCR = 1;
            return '\n';
        }
        return c;
    }
}

// Flush the output stream
int wcfflush(HANDLE hout)
{
#ifdef USE_WCIO
    return 0;                       // wcDoorWrite is not buffered
#else
    return fflush((FILE *)hout);
#endif
}

// Read a line, like fgets: at most len-1 characters including the '\n',
// always terminated.  Echo, backspace/DEL edit, other control keys and
// ANSI key sequences (arrows, function keys) ignored.  NULL on EOF.
char *wcfgets(char *ans, int len, HANDLE hin)
{
#ifdef USE_WCIO
    int i = 0;
    int ch;

    if (ans == NULL || len < 2) return NULL;
    SetColor(COLOR_INPUT);
    for (;;) {
        ch = wcgetchar();
        if (ch == EOF) {
            ans[0] = '\0';
            return NULL;
        }
        if (ch == '\n') {
            SetColor(COLOR_TEXT);
            if (EchoEnabled) DoorWrite("\r\n", 2);
            break;
        }
        if (ch == 8 || ch == 127) {
            if (i > 0) {
                i--;
                if (EchoEnabled) DoorWrite("\b \b", 3);
            }
            continue;
        }
        if (ch == 27) {             // ESC [ ... final byte 0x40-0x7E
            ch = wcgetchar();
            if (ch == '[' || ch == 'O') {
                while ((ch = wcgetchar()) != EOF && (ch < 0x40 || ch > 0x7E));
            }
            if (ch == EOF) {
                ans[0] = '\0';
                return NULL;
            }
            continue;
        }
        if (ch < 32) continue;
        if (i < len - 2) {          // room for '\n' and '\0'
            ans[i++] = (char)ch;
            if (EchoEnabled) {
                char c = (char)ch;
                DoorWrite(&c, 1);
            }
        }
    }
    ans[i++] = '\n';
    ans[i] = '\0';
    return ans;
#else
    return fgets(ans, len, (FILE *)stdin);
#endif
}

//---------------------------------------------------------------------
// output
//---------------------------------------------------------------------

// Write a single character, '\n' as \r\n
int wcputchar(int c)
{
    if (c == '\n') {
        DoorWrite("\r\n", 2);
    } else {
        char b = (char)c;
        DoorWrite(&b, 1);
    }
    return c;
}

int wcprintf(const char *format, ...)
{
    char buf[1024*5];

    va_list args;
    va_start(args, format);
    int n = _vsnprintf(buf, sizeof(buf) - 1, format, args);
    va_end(args);
    buf[sizeof(buf) - 1] = '\0';
    if (n < 0) n = (int)strlen(buf);   // truncated
    WriteText(buf, n);
    return n;
}

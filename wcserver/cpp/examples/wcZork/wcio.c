#include <stdio.h>
#include <stdlib.h>
#include <io.h>
#include <fcntl.h>
#include <windows.h>
#include <stdarg.h>

#define USE_WCIO

#ifdef USE_WCIO
#   include <wcserver.h>
#   include <wclinker.h>
#   include <wcdoor32.h>
#   pragma comment(lib,"wcdoor32.lib")
#endif  // USE_WCIO

#include "wcio.h"

int EchoEnabled     = 1;
int LineFeedEnabled = 1;
int UnixEnabled     = 1;

/* Read a single character */
int wcgetchar()
{
#ifdef USE_WCIO
    int   Active       = 2;   // When 1 pending idle timeout, when 0 exit
    int   idleTimeout  = 60;  // seconds
    while (Active) {
      switch (wcDoorEvent(idleTimeout*1000)) {

        case WCDOOR_EVENT_KEYBOARD:
             Active = 2;
             BYTE c;
             wcDoorRead(&c, 1);
             if (EchoEnabled) wcprintf("%c", c);
             if (LineFeedEnabled && c == 13) wcprintf("\n");;
             if (UnixEnabled && c == 13) c = 10;
             return c;
             break;

        case WCDOOR_EVENT_OFFLINE:
             wcprintf("\r\n** FORCE DISCONNECT **\r\n");
             Active = 0;
             break;

        case WCDOOR_EVENT_TIMEOUT:
             Active--;
             switch (Active) {
               case 0:
                   wcprintf("\r\n** IDLE TIMEOUT - GOODBYE **\r\n");
                   break;
               case 1:
                   wcprintf("\r\n** IDLE TIMEOUT IN %d SECONDS **\r\n",idleTimeout);
                   break;
             }
             break;

        case WCDOOR_EVENT_FAILED:
             Active = 0;
             break;
      }
    }
    return 0;
#else
    return getchar();
#endif
}

/* Flush the output stream */
int wcfflush(HANDLE hout)
{
#ifdef USE_WCIO
    // Not required
    return 0;
#else
    return fflush((FILE *)hout);
#endif
}

/* Read a line from input */
char *wcfgets(char *ans, int len, HANDLE hin)
{
#ifdef USE_WCIO
    int i, ch;
    for (i = 0; (i < 80) && ((ch = wcgetchar()) != EOF)
                         && (ch != '\n'); i++)
    {
        ans[i] = (char) ch;
        //printf("i: %02d ch: %c | ch: %02X | len: %d [%s]\n",i,ch, ch, strlen(ans), ans);
    }
    return ans;
#else
    return fgets(ans, len, (FILE *)stdin);
#endif
}

/* Write a single character */
int wcputchar(int c)
{
#ifdef USE_WCIO
    int n = 1;
    char buf[2] = {0};
    buf[0] = c;
    if (LineFeedEnabled && (c == '\n')) { buf[1] = '\r'; n = 2;}
    return wcDoorWrite(buf,n);
#else
    return putchar(c);
#endif
}

int wcprintf(const char *format, ...)
{
    char buf[1024*5] = {0};

    va_list args;
    va_start(args, format);
    wvsprintf(buf, format, args);
    va_end(args);
    if (LineFeedEnabled && strlen(buf) && (buf[strlen(buf)-1] == '\n')) strcat(buf,"\r");
#ifdef USE_WCIO
    return wcDoorWrite(buf,strlen(buf));
#else
    return printf(buf);
#endif

}
//---------------------------------------------------------



#pragma once

#include <windows.h>

#ifdef __cplusplus
extern "C" {
#endif

// 500.4 26.11.26 door session; switches /idle:N /record /replay:file
// /replaydelay:N
extern int wcioHelp(int argc, char **argv);    // /? -h, console
extern int wcioInit(int argc, char **argv);
extern void wcioShutdown();
extern void wcioSetIdle(int seconds);
extern DWORD wcioUserId();
extern const char *wcioUserName();
extern const char *wcioSaveFile(int forwrite);
extern const char *wcioAutoSaveFile(int forwrite);
extern void wcioPrompt(const char *s);    // prompt color; /nocolor

extern int wcfflush(HANDLE hout);
extern char *wcfgets(char *ans, int len, HANDLE hin);
extern int wcgetchar();
extern int wcputchar(int c);
extern int wcprintf(const char *format, ...);

#ifdef __cplusplus
}
#endif

#pragma once

#include <windows.h>

#ifdef __cplusplus
extern "C" {
#endif

extern int wcfflush(HANDLE hout);
extern char *wcfgets(char *ans, int len, HANDLE hin);
extern int wcgetchar();
extern int wcputchar(int c);
extern int wcprintf(const char *format, ...);

#ifdef __cplusplus
}
#endif


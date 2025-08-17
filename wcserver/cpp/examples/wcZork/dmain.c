/* DUNGEON-- MAIN PROGRAM */
/*COPYRIGHT 1980, INFOCOM COMPUTERS AND COMMUNICATIONS, CAMBRIDGE MA. 02142*/
/* ALL RIGHTS RESERVED, COMMERCIAL USAGE STRICTLY PROHIBITED */
/* WRITTEN BY R. M. SUPNIK */

#define EXTERN
#define INIT
#include <stdio.h>

#include "funcs.h"
#include "vars.h"


#define USE_WCIO
#ifdef USE_WCIO
#   include <wcdoor32.h>
#   pragma comment(lib,"wcdoor32.lib")
#endif  // USE_WCIO

void main(argc, argv)
int argc;
char **argv;
{
    printf("* wcZork Starting!\n");

#ifdef USE_WCIO
    // Initialize Wildcat! Door32 connection
    if (!wcDoorInitialize()) {
        printf("! wcDoor32 Initialization error 0x%08X\n",GetLastError());
        return;
    }
#endif

    // Original game logic
    if (init_()) {
        game_();
    }

#ifdef USE_WCIO
    // Cleanup Door32 connection
    wcDoorShutdown();
#endif
    printf("* wcZork is done!\n");
    exit_();
}




/* DUNGEON-- MAIN PROGRAM */
/*COPYRIGHT 1980, INFOCOM COMPUTERS AND COMMUNICATIONS, CAMBRIDGE MA. 02142*/
/* ALL RIGHTS RESERVED, COMMERCIAL USAGE STRICTLY PROHIBITED */
/* WRITTEN BY R. M. SUPNIK */

#define EXTERN
#define INIT
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "funcs.h"
#include "vars.h"


/* 500.4 26.11.26 door session via wcio (wcioInit, exit_ shuts it down);
 * switches (/idle:N /record /replay:file /replaydelay:N) read by wcioInit */
void main(argc, argv)
int argc;
char **argv;
{
    if (wcioHelp(argc, argv)) {     /* /? -h: before the door session */
        return;
    }
    printf("* wcZork Starting!\n");

    if (!wcioInit(argc, argv)) {
        printf("! wcDoor32 Initialization error 0x%08X\n", GetLastError());
        return;
    }

    if (init_()) {
        if (autorestore_() < 0) {   /* caller gone at the resume prompt */
            exit_();
        }
        game_();
    }
    printf("* wcZork is done!\n");
    exit_();
}

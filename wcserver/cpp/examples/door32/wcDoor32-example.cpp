//***********************************************************************
// (c) Copyright 1998-2025 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
//
// File Name : wcDoor32-Example.cpp
// Subsystem : Wildcat! DOOR32
// Date      : 10/15/2025
// Version   : 500.1
// Author    : HLS
// About     :
//
// This is a sample which shows how to use the 32-bit door interface
// (WCDOOR32.DLL).
//
// Basically you just call wcDoorInitialize to start up, and
// wcDoorShutdown to clean up.  Writing to the port is done with
// wcDoorWrite, no translation of any kind is done, just raw output.
// wcDoorRead will read characters from the input buffer.  It just
// returns with no characters read if there isn't anything to read
// (it does not block).
//
// However, this example uses the more efficient wcDoorEvent() function
// which allows you to watch for keystrokes, idle timeouts and
// disconnects!
//
// The WCDOOR32.DLL also hooks you up in the user's context in the
// Wildcat! server, so you can call Wildcat server API functions.
// The example here gets the user name.
//
//***********************************************************************
// Revision History:
// Build    Date      Author  Comments
// -----    --------  ------  -------------------------------------------
// 454.8    05/09/19  SSI     - Updated for wcSDK 8.0
// 500.1    10/15/25  SSI     - Updated for wcSDK 10.0
//***********************************************************************

#include <wcCompiler.h>

#include <windows.h>
#include <stdio.h>
#pragma hdrstop

#include <wcdoor32.h>
#include <wcserver.h>

#pragma comment(lib,"wcdoor32.lib")
#pragma comment(lib,"wcsrv2.lib")

void Wprintf(const char *s, ...)
{
  va_list args;
  va_start(args, s);
  char buf[1024];
  vsprintf(buf, s, args);
  va_end(args);
  wcDoorWrite((BYTE *)buf, (DWORD)strlen(buf));
}

/*
This wildcat! channel callback is used to watch for
SC_DISCONNECT event specifically sent to this cloned
node.
*/
DWORD SystemControlNodeChannel       = 0;
DWORD CALLBACK NodeCallback(DWORD userdata, const TChannelMessage *msg)
{
    if (msg->Channel == SystemControlNodeChannel) {
      switch (msg->UserData) {
        case SC_DISCONNECT:
            SetEvent(wcDoorGetOfflineEventHandle());
            break;
      }
    }
    return 0;
}

int main(int, char *[])
{

   //
   // Required first step for a door:
   // Initialized it!
   //

   if (!wcDoorInitialize()) {
      printf("! Could not initialize door\n\n");
      printf("! This program must be run as a 32-bit door from Wildcat.\n");
	  printf("! Exiting within 5 seconds");
      Sleep(5000);
      return 0;
   }

   //
   // Optional:
   // Prepare a callback handler to watch for the node system
   // control channel events such as SC_DISCONNECT
   //

   SetupWildcatCallback(NodeCallback,0);
   char szchNode[30];
   sprintf(szchNode,"system.control.%d",GetNode());
   SystemControlNodeChannel = OpenChannel(szchNode);

   //
   // Get the current user logged in
   //

   TUser User;
   WildcatLoggedIn(&User);

   Wprintf("Welcome to WcDoor32 Test, %s.\r\n\r\n", User.Info.Name);
   Wprintf("Press a key or ESCAPE to quit:\r\n");

   SetNodeActivity("wcDoor32 Example!");

   int   Active             = 2;   // When 1 pending idle timeout, when 0 exit
   int   idleTimeout        = 60;  // seconds

   while (Active) {
     switch (wcDoorEvent(idleTimeout*1000)) {

       case WCDOOR_EVENT_KEYBOARD:
            Active = 2;
            BYTE c;
            wcDoorRead(&c, 1);
            if (c == 27) Active = 0;
            Wprintf("%c", c);
			if (c == 13) Wprintf("%c",'\n');
            break;

       case WCDOOR_EVENT_OFFLINE:
            Wprintf("\r\n** FORCE DISCONNECT **\r\n");
            Active = 0;
            break;

       case WCDOOR_EVENT_TIMEOUT:
            Active--;
            switch (Active) {
              case 0:
                  Wprintf("\r\n** IDLE TIMEOUT - GOODBYE **\r\n");
                  break;
              case 1:
                  Wprintf("\r\n** IDLE TIMEOUT IN %d SECONDS **\r\n",idleTimeout);
                  break;
            }
            break;

       case WCDOOR_EVENT_FAILED:
            Active = 0;
            break;
     }
   }

   Wprintf("\r\n\r\nReturning to bbs...\r\n");
   wcDoorShutdown();
   Sleep(1000);
   return 0;
}

//***********************************************************************
// (c) Copyright 1998-2020 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
// File Name : wcDoor32-Example4
// Subsystem : wcSDK .NET C#
// Date      : 05/15/20
// Version   : 8.0.454.10
// Author    : HLS/SSI
//
// Revision History:
// Build    Date      Author  Comments
// -----    --------  ------  -------------------------------------------
// 454.10   05/15/20  HLS     wcDoor32 Example #4
//***********************************************************************

using System;
using System.Runtime.InteropServices;
using System.Text;
using wcSDK;
using wcSDK.wcSystem;

#if DEBUG
using System.Collections;
using System.Collections.Generic;
#endif

namespace wcDoor32_example4
{
    class Program
    {
        public static int StartDoor()
        {
            Console.WriteLine("* Starting wcDOOR32.Net CWildcatDoor **");

            CWildcatDoor door = new CWildcatDoor();

            Console.WriteLine("door.GetDeviceType(): {0}", door.GetDeviceType());
            Console.WriteLine("Node: {0}", door.Node);
            Console.WriteLine("UserName: {0}", door.UserName);
            Console.WriteLine("User.from: {0}", wcGlobal.User.From);

            door.SetGlobalTimeout(0);  // turn off timeout
            door.PrepareCallBack();    // Allow for disconnect events to be captured.

            door.ClearScreen();
            door.DisplayFile("wc:\\bats\\wcdoor32-hello.bbs");

            wcServerAPI.SetNodeActivity("wcDoor32.Net Example1!");

            door.Writeln("@T@Welcome to WcDoor32.Net Example #1, {0}.@N@", wcGlobal.User.Info.Name);
            door.Writeln("@B@User        : @A@{0}", door.UserName);
            door.Writeln("@B@Login Node  : @A@{0}", door.Node);
            door.Writeln("@B@Door Node   : @A@{0}", wcServerAPI.GetNode());
            door.Writeln("@B@Speed       : @A@{0}", door.Speed);
            door.Writeln("@B@ColorEnabled: @A@{0}", door.ColorEnabled);
            door.Writeln("\r\n@E@Press ESCAPE or / to quit:@N@");

            //------------------------------------------------------------
            // Primitive Dump Terminal
            //------------------------------------------------------------

            int Active = 2;           // When 1 pending idle timeout, when 0 exit
            int idleTimeout = 60 * 1; // seconds

            while (Active != 0)
            {
                switch (door.Event(idleTimeout * 1000))
                {
                    case wcDoor32API.WCDOOR_EVENT_KEYBOARD:
                        Active = 2;
                        byte[] data = new byte[4];
                        int rd = door.Read(ref data, data.Length);
                        if (rd == 0) continue;
                        // -------------------------------------
                        // Check first byte for escape/exit key
                        byte ch = data[0];
                        if (ch == '/') { Active = 0; break; }
                        if (ch == wcConsoleAPI.KEY_ESCAPE) { Active = 0; break; }
                        // -------------------------------------
                        if (!door.Write(data, rd))
                        {
                            Console.WriteLine("!!!!ERROR writing data!");
                        }
                        if (ch == wcConsoleAPI.KEY_CR)
                        {
                            data[0] = (byte)wcConsoleAPI.KEY_LF;
                            door.Write(data, 1);
                        }
                        break;

                    case wcDoor32API.WCDOOR_EVENT_OFFLINE:
                        door.Write("\r\n** FORCE DISCONNECT **\r\n");
                        Console.WriteLine("** WCDOOR_EVENT_OFFLINE - GOODBYE **");
                        Active = 0;
                        break;

                    case wcDoor32API.WCDOOR_EVENT_TIMEOUT:
                        Active--;
                        switch (Active)
                        {
                            case 0:
                                door.Write("\r\n** IDLE TIMEOUT - GOODBYE **\r\n");
                                break;
                            case 1:
                                door.Write("\r\n** IDLE TIMEOUT IN {0} SECONDS **\r\n", idleTimeout);
                                break;
                        }
                        break;

                    case wcDoor32API.WCDOOR_EVENT_FAILED:
                        Console.WriteLine("** WCDOOR_EVENT_FAILED - GOODBYE **");
                        Active = 0;
                        break;
                }
            }

            door.Writeln("\r\n\r\nReturning to bbs...");

            // delay 500ms, 1/2 sec, alternative door.DelayMS(500)
            // then flush, to complete transmission, if any.
            door.Delay(0.5);
            door.Flush();

            // When finishing an app, not necessary to call
            // Shutdown() here.
            // CWildcDoor's destructor will shutdown automatically.
            door.ShutDown();
            return 0;
        }

        static void Main(string[] args)
        {
#if DEBUG
            // Use this to Attach Process for debugger
            //Console.Write("<pause START>"); Console.ReadKey();
#endif 
            StartDoor();
#if DEBUG
            //Console.Write("<pause END>"); Console.ReadKey();
#endif
        }
    }

}

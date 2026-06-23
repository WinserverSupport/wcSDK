//***********************************************************************
// (c) Copyright 1998-2020 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
// File Name : wcDoor32-Example3
// Subsystem : wcSDK .NET C# 
// Date      : 05/15/20
// Version   : 8.0.454.10
// Author    : HLS/SSI
//
// Revision History:
// Build    Date      Author  Comments
// -----    --------  ------  -------------------------------------------
// 454.10   05/15/20  HLS     wcDoor32 Example #3
//***********************************************************************

using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text;
using wcSDK;
using wcSDK.wcSystem;

#if DEBUG
using System.Collections;
using System.Collections.Generic;
#endif

namespace wcDoor32_example3
{
    class Program
    {
        public static CWildcatDoor door = new CWildcatDoor();
        public static wcGlobal global = new wcGlobal();

        #region door input functions

        // This routine gets a line of text from the user, it gets the line character
        // by character.

        public static bool GetUserLine(ref String st)
        {

            int Active = 2;           // When 1 pending idle timeout, when 0 exit
            int idleTimeout = 60 * 1; // seconds

            st = "";
            while (Active != 0)
            {
                switch (door.Event(idleTimeout * 1000))
                {
                    case wcDoor32API.WCDOOR_EVENT_KEYBOARD:
                        Active = 2;
                        byte[] data = new byte[1];
                        int rd = door.Read(ref data, data.Length);
                        if (rd == 0) continue;
                        byte ch = data[0];
                        if ((ch != 13) && (ch != 10)) st += (char)ch;
                        door.Write((char)ch);
                        if (ch == 13) return true;
                        break;

                    case wcDoor32API.WCDOOR_EVENT_OFFLINE:
                        door.Write("\r\n** FORCE DISCONNECT **\r\n");
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
                        // WCDOOR_EVENT_FAILED
                        Active = 0;
                        break;
                } // switch
            } // while
            return false;
        }
        public static bool ReadYesNo(string def = "Y")
        {
            string st = "";
            bool Carrier = true;
            do
            {
                Carrier = GetUserLine(ref st);
                if (st == "") { st = def; }
            } while (Carrier && (st.ToUpper() != "Y") && (st.ToUpper() != "N"));
            return st.ToUpper() == "Y";
        }

        #endregion

        public static int StartDoorMenu()
        {
            Console.WriteLine("* Starting wcDOOR32.Net CWildcatDoor Example #3**");
            Console.WriteLine("door.GetDeviceType(): {0}", door.GetDeviceType());
            Console.WriteLine("door.Node: {0}", door.Node);
            Console.WriteLine("door.UserName: {0}", door.UserName);
            Console.WriteLine("wcGlobal.From: {0}", wcGlobal.User.From);


            door.SetGlobalTimeout(0);  // turn off timeout
            door.PrepareCallBack();    // Allow for disconnect events to be captured.

            wcServerAPI.SetNodeActivity("wcDoor32.Net Example3!");
            door.ClearScreen();
            door.Writeln("@H@Welcome to WcDoor32.Net Example #3, @N@{0}", wcGlobal.User.Info.Name);
            door.Writeln("@H@BBS Name      : @N@{0}", wcGlobal.Makewild.BBSName);
            door.Writeln("@B@User          : @A@{0}", door.UserName);
            door.Writeln("@B@Login Node    : @A@{0}", door.LoginNode);
            door.Writeln("@B@Door Node     : @A@{0}", door.Node);
            door.Writeln("@B@wcGlobal.Node : @A@{0}", wcGlobal.Node);
            door.Writeln("@B@GetNode()     : @A@{0}", wcServerAPI.GetNode());
            door.Writeln("@B@Speed         : @A@{0}", door.Speed);
            door.Writeln("@B@ColorEnabled  : @A@{0}", door.ColorEnabled);
            door.Writeln();

            wcServerAPI.TWildcatServerGuid wg = new wcServerAPI.TWildcatServerGuid();
            wcServerAPI.WcGetWildcatServerGuid(ref wg);
            door.Writeln("@B@GUID          : @A@{0}", wg.szGuid);
            door.Writeln();


            door.Write("@H@** Do you wish to continue, [Y], N?@A@");
            if (!ReadYesNo()) return 0;

            door.Writeln();
            door.Writeln("@H@** MENU OPTIONS?@A@");
            door.Writeln("@B@(1) Option 1@A@");
            door.Writeln("@B@(2) Option 2@A@");
            door.Writeln("@B@(3) Option 3@A@");
            door.Writeln("@B@(4) Option 4@A@");

            while (true)
            {
                door.Write("@H@Enter Option: ");
                while (!door.CharReady())
                {
                    door.DelayMS(15);
                }
                char ch = (char)door.ReadKey();
                if (ch >= '1' && ch <= '4') { door.Write("{0}", ch); break; }
                door.Writeln();
            }

            #region Primitive Dumb Terminal

            door.Writeln();
            door.Writeln("@E@Press / to quit:@N@");

            //------------------------------------------------------------
            // Primitive Dumb Terminal
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

#if DEBUG
                        string mykey = "";
                        string mykeystr = "";
                        for (int i = 0; i < rd; i++)
                        {
                            byte c = data[i];
                            Console.WriteLine(
                                "{0} ch:| '{1}' {2,3} (0x{3:X}) | '{4}' {5,3} (0x{6:X} <- {7} | {8} | rd: {9}",
                                "-",
                                (c < 32) ? ' ' : (char)c, c, c,
                                (c < 32) ? ' ' : (char)c, c, c,
                                mykey,
                                mykeystr,
                                rd
                             );
                        }
#endif

                        // -------------------------------------
                        // Check first byte for escape/exit key
                        byte ch = data[0];
                        if (ch == '/') { Active = 0; break; }
                        //if (ch == wcConsoleAPI.KEY_ESCAPE) { Active = 0; break; }
                        // -------------------------------------

                        // IBM Keyboard Scan Codes will come from a wcBASIC 
                        // login to run the door.
                        if (ch == 0)
                        {
                            if (rd == 1)
                            {
                                ch = (byte)door.ReadKey();  // need to read extra key
                            }
                            else if (rd == 2) ch = data[1];

                            switch (ch)
                            {
                                case (byte)'H': door.CursorUp(); break;
                                case (byte)'P': door.CursorDown(); break;
                                case (byte)'K': door.CursorLeft(); break;
                                case (byte)'M': door.CursorRight(); break;
                            }
                            continue;
                        }

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
                        // ** WCDOOR_EVENT_FAILED
                        Active = 0;
                        break;
                }
            }
            #endregion

            door.Writeln("\r\n\r\nReturning to bbs...");
            door.Flush();
            return 0;
        }

        static void Main(string[] args)
        {
#if DEBUG
            // Use this to Attach Process for debugger
            //Console.Write("<pause START>"); Console.ReadKey();
#endif
            StartDoorMenu();
#if DEBUG
            //Console.Write("<pause END>"); Console.ReadKey();
#endif
        }
    }

}

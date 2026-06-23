//***********************************************************************
// (c) Copyright 1998-2020 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
//
// File Name : wcdoor32Api.cs
// Subsystem : Wildcat! Door32 for .NET
// Date      : 04/16/2020
// Version   : 8.0.454.10
// Author    : HLS/SSI
//
// Revision History:
// Build    Date      Author  Comments
// -----    --------  ------  -------------------------------------------
// 452.5    03/07/08  HLS     - Added WCDOOR_EVENT_XXXXXX
//                            - Added DoorEvent()
//
// 452.6    10/01/08  HLS     - For consistency and to help reduce
//                              long time conflict with door32.sys,
//                              door32.h was renamed to wcdoor32.h
//
// 454.10   04/16/20  HLS     - C# version of wcDoor32 header
// 454.10a  05/10/20  HLS     - Some clean up
//                            - Virtualized the WildcatCallbackFunc function.
//
//***********************************************************************

#define USE_CALLBACK

using System;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;

using wcSDK.wcSystem;

namespace wcSDK
{
    #region Credits ...

    // ------------------------------------------------------------------------
    // (c) Copyright 1998-2020 by Santronics Software Inc. All Rights Reserved.
    // Wildcat! Door 32bit API v8.0.454.10
    //
    // CUSTOM/MANUALLY UPDATED
    // ------------------------------------------------------------------------

    #endregion

    public class wcTools
    {
        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                bytes[i] = (byte)str[i];
            }
            /*
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            */
            return bytes;
        }
        public static char[] GetChars(string str)
        {
            char[] bytes = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                bytes[i] = str[i];
            }
            return bytes;
        }


        public static string GetString(byte[] bytes)
        {
            //char[] chars = new char[bytes.Length];
            string s = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] == 0) break;
                //chars[i] = (char)bytes[i];
                s += (char)bytes[i];
            }
            /*
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            */
            //return new string(chars);
            return s;
        }
        public static string GetString(char[] bytes)
        {
            string s = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] == 0) break;
                s += (char)bytes[i];
            }
            return s;
        }
        public static string GetDoorPath()
        {
            string[] _args = Environment.GetCommandLineArgs();
            for (int i = 0; i < _args.Length; i++)
            {
                if (_args[i].ToLower().StartsWith("/dp:") || _args[i].ToLower().StartsWith("-dp:"))
                {
                    return _args[i].Substring(4);
                }
            }
            return "";
        }
    }

    public class wcDoor32API
    {
        #region Public Wildcat! Door32 API Constants ...

        public const int WCDOOR_EVENT_BASE = 0;
        public const int WCDOOR_EVENT_FAILED = WCDOOR_EVENT_BASE + 0;
        public const int WCDOOR_EVENT_TIMEOUT = WCDOOR_EVENT_BASE + 1;
        public const int WCDOOR_EVENT_KEYBOARD = WCDOOR_EVENT_BASE + 2;
        public const int WCDOOR_EVENT_OFFLINE = WCDOOR_EVENT_BASE + 3;

        #endregion

        #region Public Wildcat! Door32  API Structures ...
        #endregion

        #region Public Wildcat! Door32 API DLL Imports ...

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorInitialize
        ////! Initialize a wcDoor32 application
        ////! returns TRUE if successful, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorInitialize", SetLastError = true)]
        public extern static bool WcDoorInitialize();

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorShutdown
        ////! Shutdown a wcDoor32 application.
        ////! returns TRUE if successful, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorShutdown", SetLastError = true)]
        public extern static bool WcDoorShutdown();

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorHangUp
        ////! Disconnect (hangup) communications with user
        ////! returns TRUE if successful, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorHangUp", SetLastError = true)]
        public extern static bool WcDoorHangUp();

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorCharReady
        ////! Check if a character is available to be read or peeked.
        ////! returns TRUE if successful, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorCharReady", SetLastError = true)]
        public extern static int WcDoorCharReady();

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorRead
        ////! Read a character from input buffer
        ////! returns number of bytes read otherwise 0
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorRead", SetLastError = true)]
        public extern static int WcDoorRead(byte[] data, int size);

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorPeek
        ////! Read/Peek a character without removing from input buffer.
        ////! returns number of bytes peeked otherwise 0
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorReadPeek", SetLastError = true)]
        public extern static int WcDoorReadPeek(byte[] data, int size);

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorWrite
        ////! Write characters to output buffer
        ////! returns TRUE if data is written, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorWrite", SetLastError = true)]
        public extern static bool WcDoorWrite(byte[] data, int size);

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorGetAvailableEventHandle
        ////! get the event handle to process
        ////! returns HANDLE if successful, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorGetAvailableEventHandle", SetLastError = true)]
        public extern static int WcDoorGetAvailableEventHandle();

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorGetOfflineEventHandle
        ////! get the offline handle to process
        ////! returns HANDLE if successful, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorGetOfflineEventHandle", SetLastError = true)]
        public extern static int WcDoorGetOfflineEventHandle();

        ////!----------------------------------------------------------------
        ////! Group: wcDoor32 API
        ////! DoorEvent
        ////! Get the event if any with a timeput
        ////! returns event handle if successful, otherwise see extended error
        ////!----------------------------------------------------------------
        [DllImport("wcdoor32.dll", EntryPoint = "DoorEvent", SetLastError = true)]
        public extern static int WcDoorEvent(int timeout);

        #endregion

        #region "Helper functon"
        /// <summary>
        /// Helper Function:
        /// </summary>
        /// <param name="err">WIldcat! error number</param>
        /// <returns>returns Wildcat! error string</returns>
        public static string WildcatError(int err)
        {
            return "TBD";
        }
        /// <summary>
        /// Helper Function: DoorWrite overload for formating output
        /// </summary>
        /// <param name="fmt">format string</param>
        /// <param name="v">variable arguments</param>
        /// <returns>returns true if successful writing all bytes</returns>

        public static bool WcDoorWrite(string fmt, params object[] v)
        {
            if (fmt == null) return false;
            String buf = "";
            if (v.Length == 0) buf = fmt;
            buf = String.Format(fmt, v);
            byte[] data = wcTools.GetBytes(buf); // Encoding.ASCII.GetBytes(buf);
            return WcDoorWrite(data, data.Length);
        }

#if FALSE
        public static int WcReadKey()
        {
            //if (wcSDK.wcServerAPI.GetCallerType)
            //if (WILDCATG(httpmode)) RETURN_LONG(0);
            return Console.Read();
        }

        public static bool WcKeyPressed()
        {
            //if (WILDCATG(httpmode)) RETURN_FALSE;
            //RETURN_BOOL(_kbhit());
            return Console.KeyAvailable;
        }
#endif

        #endregion
    } // end of wcDoor32API

    public interface iWildcatConsoleIO
    {
        string GetDeviceType();
        bool Initialize();
        bool PrepareCallBack();
        bool ShutDown();
        int Event(int msecs);
        bool Write(char ch);
        bool Write(byte[] data, int size);
        bool Writeln(byte[] data, int size);
        bool Write(string fmt, params object[] v);
        bool Writeln(string fmt, params object[] v);
        bool Writeln();
        int Read(ref byte[] data, int size = 1024);
        int Peek(ref byte[] data, int size = 1024);
        bool CharReady();
        uint ReadKey();
        void ClearScreen(string v = "2");
        int GotoXY(int x, int y);
        void EraseLine(string v = "");
        byte GetColor();
        byte Color(int fb);
        byte Color(int f, int b);
        void CursorUp(int amt = 1);
        void CursorDown(int amt = 1);
        void CursorLeft(int amt = 1);
        void CursorRight(int amt = 1);
        void CursorSave();
        void CursorRestore();
    }

    class CWildcatDeviceDoor32 : iWildcatConsoleIO
    {
        public string GetDeviceType() { return "WCDOOR32"; }
        public bool Initialize() { return wcDoor32API.WcDoorInitialize(); }
        public bool PrepareCallBack()
        {
#if USE_CALLBACK
            wcServerAPI.TWildcatCallBack myCallBack = new wcServerAPI.TWildcatCallBack(WildcatCallBackFunc);
            wcServerAPI.SetupWildcatCallback(myCallBack, 0);
            string sNode = string.Format("system.control.{0}", wcServerAPI.GetNode());
            SystemControlNodeChannel = (uint)wcServerAPI.OpenChannel(sNode);
            Console.WriteLine("* node: {0} OpenChannel(\"{1}\") : SystemControlNodeChannel: {2}",
                wcServerAPI.GetNode(), sNode, SystemControlNodeChannel);
#endif
            return true;
        }
        public bool ShutDown() { return wcDoor32API.WcDoorShutdown(); }
        public int Event(int msecs) { return wcDoor32API.WcDoorEvent(msecs); }
        public bool Write(char ch) {
            byte[] data = new byte[1]; data[0] = (byte)ch;
            return wcDoor32API.WcDoorWrite(data, 1);
        }
        public bool Write(byte[] data, int size) { return wcDoor32API.WcDoorWrite(data, size); }
        public bool Writeln(byte[] data, int size) { return wcDoor32API.WcDoorWrite(data, size); }
        public bool Write(string fmt, params object[] v)
        {
            if (fmt == null) return false;
            String buf = "";
            if (v.Length == 0) buf = fmt;
            buf = String.Format(fmt, v);
            byte[] data = wcTools.GetBytes(buf);  // Encoding.ASCII.GetBytes(buf);
            return wcDoor32API.WcDoorWrite(data, data.Length);
        }
        public bool Writeln(string fmt, params object[] v)
        {
            if (fmt == null) return false;
            String buf = "";
            if (v.Length == 0) buf = fmt;
            buf = String.Format(fmt, v) + "\r\n";
            byte[] data = wcTools.GetBytes(buf); // Encoding.ASCII.GetBytes(buf);
            return wcDoor32API.WcDoorWrite(data, data.Length);

        }
        public bool Writeln() { return Write("\r\n"); }
        public int Read(ref byte[] data, int size = 1024)
        {
            return wcDoor32API.WcDoorRead(data, size);
        }
        public int Peek(ref byte[] data, int size = 1024) { return wcDoor32API.WcDoorReadPeek(data, size); }
        public bool CharReady() { return wcDoor32API.WcDoorCharReady() != 0; }
        public uint ReadKey()
        {
            byte[] data = new byte[1];
            int rd = wcDoor32API.WcDoorRead(data, data.Length);
            if (rd == 1) return data[0];
            return 0;
        }


        // not accountered for completely, don't use until then.
        public int ci_x = 0;  
        public int ci_y = 0;
        public int ci_fg = wcConsoleAPI.LightGray;

        public void ClearScreen(string v = "2")
        {
            Write("{0}[{1}J", wcConsoleAPI.KEY_ESCAPE, v);
        }
        public int GotoXY(int x, int y)
        {
            ci_y = y;
            ci_x = x;
            Write("{0}[{1};{2}H", wcConsoleAPI.KEY_ESCAPE, y, x);
            return 0;
        }
        /// <summary>
        /// Clear the line 
        /// </summary>
        /// <param name="v">
        /// ""  Esc[K	Clear line from cursor right	EL0
        /// "0" Esc[0K  Clear line from cursor right    EL0
        /// "1" Esc[1K  Clear line from cursor left EL1
        /// "2" Esc[2K  Clear entire line   EL2
        /// </param>
        public void EraseLine(string v = "")
        {
            Write("{0}[{1}K", wcConsoleAPI.KEY_ESCAPE, v);
        }

        public byte GetColor()
        {
            return (byte)ci_fg;
        }
        public byte Color(int f)
        {
            ci_fg = (GetColor() & 0xF0) | (f & 0xF);
            //string s = String.Format("@{0:X2}@", fg);
            //Write(wcConsoleAPI.ExpandMacros(s));
            Write(wcConsoleAPI.AnsiColor((byte)ci_fg));
            return 0;
        }
        public byte Color(int f, int b)
        {
            ci_fg = ((b & 0xF) << 4) | (f & 0xF);
            //return Color(fg);
            Write(wcConsoleAPI.AnsiColor((byte)ci_fg));
            return 0;
        }
        public void CursorUp(int amt = 1) { Write("{0}[{1}A", wcConsoleAPI.KEY_ESCAPE, amt); }
        public void CursorDown(int amt = 1) { Write("{0}[{1}B", wcConsoleAPI.KEY_ESCAPE, amt); }
        public void CursorLeft(int amt = 1) { Write("{0}[{1}D", wcConsoleAPI.KEY_ESCAPE, amt); }
        public void CursorRight(int amt = 1) { Write("{0}[{1}C", wcConsoleAPI.KEY_ESCAPE, amt); }

        static string _savedCursor = "";
        public void CursorSave()
        {
            _savedCursor = "";
            Write("{0}[6n", wcConsoleAPI.KEY_ESCAPE);
            Thread.Sleep(500);
            byte[] data = new byte[16];
            int rd = Read(ref data, data.Length);
            if (rd > 0 && data[0] == wcConsoleAPI.KEY_ESCAPE)
            {
                _savedCursor = wcTools.GetString(data);
                if (!_savedCursor.EndsWith("R")) _savedCursor = "";
            }
            Console.WriteLine("save _savedCursor: [{0}]", _savedCursor);
        }
        public void CursorRestore()
        {
            Console.WriteLine("restore _savedCursor: [{0}]", _savedCursor);
            if (_savedCursor.Length == 0) return;
            _savedCursor = _savedCursor.Replace('R', 'H');
            Write("{0}", _savedCursor);
        }

#if USE_CALLBACK
        #region "Private Delegates ..."
        #endregion
        [DllImport("kernel32.dll")]
        static extern bool SetEvent(IntPtr hEvent);

        private static uint SystemControlNodeChannel = 0;
        public virtual int WildcatCallBackFunc(int UserData, ref wcServerAPI.TChannelMessage msg)
        {
            Console.WriteLine("msg.Channel: {0} msg.SenderId: {1}, msg.UserData: {2}", msg.Channel, msg.SenderId, msg.UserData);
            if (msg.Channel == SystemControlNodeChannel)
            {
                switch (msg.UserData)
                {
                    case wcServerAPI.SC_DISCONNECT:
                        SetEvent((IntPtr)wcDoor32API.WcDoorGetOfflineEventHandle());
                        Console.WriteLine("SC_DISCONNECT");
                        break;
                }
            }
            return 0;
        }
#endif
    }  // end of CWildcatDeviceDoor32

    class CWildcatDeviceCRT32 : iWildcatConsoleIO
    {
        public string GetDeviceType() { return "WCCRT32"; }
        public bool Initialize() { return true; }
        public bool PrepareCallBack()
        {
            return false;
        }
        public bool ShutDown() { return true; }
        public int Event(int msecs)
        {
            int atime = 0;
            int slice = 15;
            while (true)
            {
                if (Console.KeyAvailable) return wcDoor32API.WCDOOR_EVENT_KEYBOARD;
                Thread.Sleep(slice);
                atime += slice;
                if (atime >= msecs) break;
            }
            return wcDoor32API.WCDOOR_EVENT_TIMEOUT;
        }

        public bool Write(char ch)
        {
            Console.Write(ch);
            return true;
        }

        public bool Write(byte[] data, int size)
        {
            string s = wcTools.GetString(data);
            Console.Write(s);
            return true;
        }
        public bool Writeln(byte[] data, int size)
        {
            string s = wcTools.GetString(data);
            Console.WriteLine(s);
            return true;
        }
        public bool Write(string fmt, params object[] v)
        {
            if (fmt == null) return false;
            Console.Write(fmt, v);
            return true;
        }
        public bool Writeln(string fmt, params object[] v)
        {
            if (fmt == null) return false;
            Console.WriteLine(fmt, v);
            return true;
        }
        public bool Writeln()
        {
            Console.WriteLine();
            return true;
        }
        public int Read(ref byte[] data, int size = 1024)
        {

#if true
            int i = 0;
            while (Console.KeyAvailable)
            {
                ConsoleKey k = Console.ReadKey(true).Key;
                data[i] = (byte)Console.ReadKey(true).KeyChar;
                i++;
                if (i >= size) break;
            }
            return i;
#else
            string s = "";
            while (Console.KeyAvailable)
            {
                s += Console.ReadKey(true).KeyChar;
                if (s.Length >= size) break;
            }
            data = wcTools.GetBytes(s);
/*
            byte[] inb = wcTools.GetBytes(s);
            if (inb.Length == data.Length)
            {
                data = inb;
            } else {
                for (int i = 0;  i < inb.Length; i++)
                {
                    data[i] = inb[i];
                }
            }
*/
            return s.Length;
#endif

        }
        public int Peek(ref byte[] data, int size = 1024)
        {
            string s = "";
            while (Console.KeyAvailable)
            {
                s += Console.ReadKey(true).KeyChar;
                if (s.Length > size) break;
            }
            data = wcTools.GetBytes(s);  // Encoding.ASCII.GetBytes(s);
            return s.Length;
        }
        public uint ReadKey()
        {
            uint b = (uint)Console.ReadKey(true).KeyChar;
            return b;
        }
        public bool CharReady()
        {
            return Console.KeyAvailable;
            //return wcDoor32API.WcKeyPressed();
        }
        /// <summary>
        /// Console emulation of clear screen
        /// </summary>
        /// <param name="v">
        /// ""  Esc[J   Clear screen from cursor down   ED0
        /// "0" Esc[0J  Clear screen from cursor down   ED0
        /// "1" Esc[1J  Clear screen from cursor up ED1
        /// "2" Esc[2J  Clear entire screen ED2
        /// </param>
        public void ClearScreen(string v = "2")
        {
            int y = Console.CursorTop;
            int x = Console.CursorLeft;
            int iv;
            if (v == "") v = "0";
            if (!int.TryParse(v, out iv)) iv = 2;
            switch (iv)
            {
                case 0: // from Y to Last Row
                    for (int i = y; i < Console.WindowHeight; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.Write(new string(' ', Console.WindowWidth));
                    }
                    Console.SetCursorPosition(x, y);
                    break;
                case 1: // from Y to 1
                    for (int i = Console.WindowTop; i < (y + 1); i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.Write(new string(' ', Console.WindowWidth));
                    }
                    Console.SetCursorPosition(x, y);
                    break;
                case 2:
                    Console.Clear();
                    break;
                default: break;
            }
        }
        public int GotoXY(int x, int y)
        {
            //if ((x - 1) < Console.WindowTop) return;
            //if ((x - 1) > Console.WindowHeight) return;
            try
            {
                Console.SetCursorPosition(x - 1, y - 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("GotoXY(x={0}, y={1}\n{2})", x - 1, y - 1, e.Message);
            }
            return 0;
        }
        /// <summary>
        /// Clear the line 
        /// </summary>
        /// <param name="v">
        /// Esc[K	Clear line from cursor right	EL0
        /// Esc[0K  Clear line from cursor right    EL0
        /// Esc[1K  Clear line from cursor left EL1
        /// Esc[2K  Clear entire line   EL2
        /// </param>
        public void EraseLine(string v = "2")
        {
            //Write("{0}[{1}K", wcConsoleAPI.KEY_ESCAPE, v);
            /*
            int y = Console.CursorTop;
            int x = Console.CursorLeft;
            int w = Console.WindowWidth - x;
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', w));
            Console.SetCursorPosition(x, y);
            */

            int y = Console.CursorTop;
            int x = Console.CursorLeft;
            int iv;
            if (v == "") v = "0";
            if (!int.TryParse(v, out iv)) iv = 2;

            switch (iv)
            {
                case 0: // from x to end of row (Cursor Right)
                    {
                        int w = Console.WindowWidth - x;
                        Console.Write(new string(' ', w));
                        Console.SetCursorPosition(x, y);
                        break;
                    }
                case 1: // from x to beginning of row (cursor left)
                    {
                        int w = x;
                        Console.SetCursorPosition(0, y);
                        Console.Write(new string(' ', w));
                        Console.SetCursorPosition(x, y);
                        break;
                    }
                case 2:
                    {
                        int w = Console.WindowWidth;
                        Console.SetCursorPosition(0, y);
                        Console.Write(new string(' ', w));
                        Console.SetCursorPosition(x, y);
                        break;
                    }
                default: break;
            }
        }
        public byte GetColor()
        {
            byte f = (byte)Console.ForegroundColor;
            byte b = (byte)Console.BackgroundColor;
            int c = (byte)((b & 0xF) << 4) | (byte)(f & 0xF);
            return (byte)c;
        }
        public byte Color(int f)
        {
            //Write("@%02X@", (GetColor() & 0xF0) | (f & 0xF));
            return 0;
        }
        public byte Color(int f, int b)
        {
            //Write("@%02X@", ((b & 0xF) << 4) | (f & 0xF));
            byte of = (byte)Console.ForegroundColor;
            byte ob = (byte)Console.BackgroundColor;
            Console.ForegroundColor = (ConsoleColor)f;
            Console.BackgroundColor = (ConsoleColor)b;
            return 0;
        }
        public void CursorUp(int amt = 1) { throw new NotImplementedException(); }
        public void CursorDown(int amt = 1) { throw new NotImplementedException(); }
        public void CursorLeft(int amt = 1) { throw new NotImplementedException(); }
        public void CursorRight(int amt = 1) { throw new NotImplementedException(); }
        public void CursorSave() { }
        public void CursorRestore() { }

    } // end of CWildcatDeviceCRT32

    public class CWildcatConsole : wcServerAPI

    {
        //-----------------
        // Options
        //-----------------

        public uint GlobalTimeoutSecs = 0;
        public uint IdleTimeoutSecs = 60;
        public uint InputBufferSize = 0;

        //-----------------
        // Variables Set by Class
        //-----------------
        //public TUser User;           // moved to wcGlobal
        public string UserName = "";
        public int Node = 0;
        public int LoginNode = 0;
        public Dictionary<string, string> DoorSys = new Dictionary<string, string>();
        public Dictionary<string, string> Door32Sys = new Dictionary<string, string>();

        //-----------------
        // private
        //-----------------

        private bool Active = false;
        private uint _StartTime = 0;
        private iWildcatConsoleIO _interface = null;

        public CWildcatConsole(iWildcatConsoleIO _interface = null)
        {

            if (this._interface == null)
            {
                string sPipe = Environment.GetEnvironmentVariable("wcdoorpipename");
                if (sPipe != null)
                    _interface = new CWildcatDeviceDoor32();
                else
                    _interface = new CWildcatDeviceCRT32();
            }
            this._interface = _interface;

            //set_time_limit($this->GlobalTimeoutSecs);
            _StartTime = GetTime(); // time();
            string sLoginNode = Environment.GetEnvironmentVariable("WCNODEID");
            if (sLoginNode != null) this.LoginNode = Int32.Parse(sLoginNode);

            if (this._interface.Initialize())
            {
                if (this._interface.GetDeviceType() == "WCDOOR32")
                {
                    Active = true;
                    WildcatLoggedIn(ref wcGlobal.User);
                    TrimTUser(ref wcGlobal.User);
                    UserName = wcGlobal.User.Info.Name;
                    Node = wcGlobal.Node;
                    DoorSys = ReadDoorSys();
                    Door32Sys = ReadDoor32Sys();
                    wcConsoleAPI.ColorEnabled = DoorSysValue("DisplayMode") == "GR";
                    wcConsoleAPI.AnsiDetected = DoorSysValue("AnsiDetected") == "Y";
                    //this.InitOutputFilter();
                    Flush();
                    return; // true;
                }
                if (this._interface.GetDeviceType() == "WCCRT32")
                {
                    Active = true;
                    //this.InitOutputFilter();
                    Flush();
                    return; // true;
                }
            }
            //$this->InitOutputFilter();
            Console.Write("! Could not initialize door. Unknown Device Type: {0}\n", this._interface.GetDeviceType());
            //$this->DelayMS(2000);
            return; // false;
        }

        ~CWildcatConsole()
        {
            ShutDown();
        }
        //---------------
        // Public
        //---------------
        public bool PrepareCallBack()
        {
            return this._interface.PrepareCallBack();
        }
        public bool ShutDown()
        {
            if (this.Active)
            {
                this._interface.ShutDown();
                this.Active = false;
            }
            return this.Active;
        }
        public string GetDeviceType() { return this._interface.GetDeviceType(); }
        public int Read(ref byte[] data, int size = 1024) { return this._interface.Read(ref data, size); }
        public bool CharReady() { return this._interface.CharReady(); }
        public int Peek(ref byte[] data, int size = 1024) { return this._interface.Peek(ref data, size); }
        public uint ReadKey() { uint ch = this._interface.ReadKey(); return ch; }
        public int Event(int msecs) { return this._interface.Event(msecs); }
        public bool Write(char ch) { return this._interface.Write(ch); }
        public bool Write(byte[] data, int size) { return this._interface.Write(data, size); }
        public bool Writeln(byte[] data, int size) { return this._interface.Writeln(data, size); }
        public bool Write(string fmt, params object[] v)
        {
            if (fmt == null) return false;
            String buf = "";
            if (v.Length == 0) buf = fmt;
            buf = wcConsoleAPI.ExpandMacros(String.Format(fmt, v));
            //buf = buf.Replace("\n", "\r\n");
            byte[] data = wcTools.GetBytes(buf); // Encoding.ASCII.GetBytes(buf);
            return this._interface.Write(data, data.Length);
        }
        public bool Writeln(string fmt, params object[] v)
        {
            if (fmt == null) return false;
            String buf = "";
            if (v.Length == 0) buf = fmt;
            buf = wcConsoleAPI.ExpandMacros(String.Format(fmt, v));
            //buf = buf.Replace("\n", "\r\n");
            buf += "\r\n";
            byte[] data = wcTools.GetBytes(buf); // Encoding.ASCII.GetBytes(buf);
            return this._interface.Write(data, data.Length);
        }
        public bool Write(int x, int y, string fmt, params object[] v)
        {
            GotoXY(x, y);
            return Write(fmt, v);
        }
        public bool Writeln() { return this._interface.Write("\r\n"); }
        //-------------------------------------------------------------
        // void Delay(int sec)
        //
        // sleep by seconds or fractions of second, i.e; Delay(0.5)
        // Same as WCBASIC Delay()
        //
        // void DelayMS(int msec)
        // sleep by millisecs
        //-------------------------------------------------------------
        public void Delay(double secs)
        {
            int msecs = (int)(secs * (float)1000.0);
            Thread.Sleep(msecs);
        }
        public void DelayMS(int msecs)
        {
            Thread.Sleep(msecs);
        }
        public void SetGlobalTimeout(uint secs)
        {
            GlobalTimeoutSecs = secs;
        }
        //-------------------------------------------------------------
        // uint GetTime()
        //
        // Return millisecs since 1970.
        //-------------------------------------------------------------
        public uint GetTime()
        {
            TimeSpan span = System.DateTime.UtcNow.Subtract(new System.DateTime(1970, 1, 1, 0, 0, 0));
            return (uint)span.Milliseconds;
        }
        public uint StartTimer()
        {
            _StartTime = GetTime(); // time();
            return _StartTime;
        }
        public uint Elapsed()
        {
            return GetTime() - _StartTime;
        }
        public void Bell(int n = 1)
        {
            byte[] data = new byte[] { 7 };
            while ((n--) > 0)
            {
                this._interface.Write(data, data.Length);
                this.DelayMS(200);
            }
        }
        public char GetKey(bool passive = true, uint timeout = 0)
        {
            if (timeout != 0) SetGlobalTimeout(timeout);
            while (true)
            {
                DelayMS(15);
                byte[] c = new byte[] { 0 };
                if (this._interface.Read(ref c, 1) > 0)
                {
                    if (passive) this._interface.Write(c, 1);
                    return (char)c[0];
                }
            }
            // C# smart to say "unreachable code"
            //return (char)0;
        }
        public void WaitEnter()
        {
            Write("@N@Press [@H@ENTER@N@] To Continue:@L@ ");
            while (GetKey() != 13) ;
            Writeln();
        }
        public void Flush(bool dump = false)
        {

            byte[] c = new Byte[1024];
            while (CharReady() && (Read(ref c, c.Length) > 0))
            {
                if (dump)
                {
                    for (int i = 0; i < c.Length; i++)
                    {
                        char ch = (char)c[i];
                        if (c[i] < 32)
                        {
                            Console.WriteLine("{0} = 0x{1:X}", i, ch);
                        }
                        else
                        {
                            Console.WriteLine("{0} = {1}", i, ch);
                        }

                    }
                }
            }

        }
        public bool DisplayFile(string fn = "")
        {
            if (fn == null || fn.Length == 0) return false;
            string tx = wcServerAPI.GetText(fn);
            if (tx == null) return false;
            byte[] data = wcTools.GetBytes(wcConsoleAPI.ExpandMacros(tx));
            Write(data, data.Length);
            return true;
        }
        public string DoorSysValue(string key)
        {
            if (DoorSys.ContainsKey(key))
            {
                return DoorSys[key];
            }
            return "";
        }
        Dictionary<string, string> ReadDoorSys()
        {
            string[] DoorSysFields = {
                    "Port",                   // Port
                    "Speed",                  // Speed
                    "DataBits",               // Data Bits
                    "LoginNode",              // Login Node
                    "DteSpeed",               // Dte Speed
                    "ScreenWrite",            // Screen Write
                    "Printer",                // Printer
                    "Page",                   // P`age
                    "Bell",                   // Bell
                    "Name",                   // Name
                    "From",                   // From
                    "PhoneNumber",            // Phone Number
                    "DataNumber",             // Data Number
                    "Password",               // Password
                    "Profile",                // Profile
                    "Calls",                  // Calls
                    "LastCall",               // Last Call
                    "SecondsRemaining",       // Seconds Remaining
                    "MinutesRemaining",       // Minutes Remaining
                    "DisplayMode",            // Display Mode
                    "LinesPerPage",           // Lines Per Page
                    "ExpertMode",             // Expert Mode
                    "Conferences",            // Conferences (comma delimiter)
                    "ConferenceNumber",       // Current Conference Number
                    "ExpireDate",             // Expire Date
                    "UserRefNumber",          // User Ref Number
                    "Protocol",               // Protocol
                    "Uploads",                // Uploads
                    "Downloads",              // Downloads
                    "DownloadKToday",         // Download K Today
                    "MaxDownloadKPerDay",     // Max Download K Per Day
                    "Birthdate",              // Birthdate
                    "UserDatabasePath",       // User Database Path
                    "HomePath",               // Home Path
                    "SysopName",              // Sysop Name
                    "AliasName",              // Alias Name
                    "NextEvent",              // Next Event
                    "ReliableConnect",        // Reliable Connect
                    "AnsiDetected",           // Ansi Detected
                    "Network",                // Network
                    "NoIdea1",                // No Idea
                    "BankedTime",             // Banked Time
                    "LastNewFiles",           // Last New Files
                    "TimeCalled",             // Time Called
                    "PreviousLogoff",         // Previous Logoff
                    "MaxDownloads",           // Max Downloads
                    "DownloadsToday",         // Downloads Today
                    "TotalUploadK",           // Total Upload K
                    "TotalDownloadK",         // Total Download K
                    "CommentField",           // Comment Field
                    "NoIdea2",                // No Idea
                    "MessagesWritten"         // Messages Written
                 };

            string dropFile = "door.sys";
            string dropPath = wcTools.GetDoorPath();
            if (dropPath.ToLower().EndsWith(dropFile)) {
               dropFile = dropPath;
            } else {
               if (dropPath.Length > 0 && !dropPath.EndsWith("\\"))
                    dropPath += "\\";
               dropFile = dropPath + dropFile;
            }
            Console.WriteLine("dropFile: {0}", dropFile);

            Dictionary<string, string> map = new Dictionary<string, string>();
            if (File.Exists(dropFile))
            {
                string dsyslines = File.ReadAllText(dropFile);
                string[] sep = { "\r\n" };
                string[] DoorSysValues = dsyslines.Split(sep, DoorSysFields.Length, StringSplitOptions.None);
                for (int i = 0; i < DoorSysFields.Length; i++)
                {
                    map.Add(DoorSysFields[i], DoorSysValues[i].Trim());
                }
            }
            return map;
        }
        public string Door32SysValue(string key)
        {
            if (Door32Sys.ContainsKey(key))
            {
                return Door32Sys[key];
            }
            return "";
        }
        Dictionary<string, string> ReadDoor32Sys()
        {
            string[] Door32SysFields = {
                    "SessionType",            // Line 1 : 0=local, 1=serial, 2=telnet, 3=Wildcat
                    "CommHandle",             // Line 2 : Comm or socket handle
                    "Speed",                  // Line 3 : Baud Rate
                    "SystemName",             // Line 4 : BBSID (software name and version) 
                    "UserID",                 // Line 5 : User.Info.Id
                    "UserRealName",           // Line 6 : User.RealName
                    "UserName",               // Line 7 : User.Info.Name
                    "UserSecurity",           // Line 8 : User's Security # for Door or Security Profile Name
                    "TimeLeft",               // Line 9 : Time Remaining
                    "ColorEnabled",           // Line 10: Emulation
                    "LoginNode"               // Line 11: Current Node #
                 };

            string dropFile = "door32.sys";
            string dropPath = wcTools.GetDoorPath();
            if (dropPath.ToLower().EndsWith(dropFile))
            {
                dropFile = dropPath;
            }
            else
            {
                if (dropPath.Length > 0 && !dropPath.EndsWith("\\"))
                    dropPath += "\\";
                dropFile = dropPath + dropFile;
            }
            Console.WriteLine("dropFile: {0}", dropFile);

            Dictionary<string, string> map = new Dictionary<string, string>();
            if (File.Exists(dropFile))
            {
                string dsyslines = File.ReadAllText(dropFile);
                string[] sep = { "\r\n" };
                string[] Door32SysValues = dsyslines.Split(sep, Door32SysFields.Length, StringSplitOptions.None);
                for (int i = 0; i < Door32SysFields.Length; i++)
                {
                    map.Add(Door32SysFields[i], Door32SysValues[i].Trim());
                }
            }
            return map;
        }

        #region Properties
        public string Speed
        {
            get
            {
                if (DoorSys.ContainsKey("Speed"))
                {
                    return DoorSys["Speed"];
                }
                return "";
            }
        }
        public bool ColorEnabled
        {
            get { return wcConsoleAPI.ColorEnabled; }
            set { wcConsoleAPI.ColorEnabled = value; }
        }
        public bool AnsiDetected
        {
            get { return wcConsoleAPI.AnsiDetected; }
            set { wcConsoleAPI.AnsiDetected = value; }
        }
        #endregion
        public void ClearScreen(string v = "2") { this._interface.ClearScreen(v); }
        public int GotoXY(int x, int y) { return this._interface.GotoXY(x, y); }
        public int Color(int f) { return this._interface.Color(f); }
        public int Color(int f, int b) { return this._interface.Color(f, b); }
        public void EraseLine(string v = "2") { this._interface.EraseLine(v); }
        public void CursorUp(int amt = 1) { this._interface.CursorUp(amt); }
        public void CursorDown(int amt = 1) { this._interface.CursorDown(amt); }
        public void CursorLeft(int amt = 1) { this._interface.CursorLeft(amt); }
        public void CursorRight(int amt = 1) { this._interface.CursorRight(amt); }
        public void CursorSave() { this._interface.CursorSave(); }
        public void CursorRestore() { this._interface.CursorRestore(); }

    } // end of CWildcatConsole

    //------------------------------------------------------------
    // Use this class for pure DOO32 operations
    //------------------------------------------------------------

    public class CWildcatDoor : CWildcatConsole
    {
        public CWildcatDoor() : base()
        {
            string sPipe = Environment.GetEnvironmentVariable("wcdoorpipename");
#if DEBUG
            Console.WriteLine("CWildcatDoor.wcdoorpipename: [{0}]", sPipe);
#endif
#if SKIP
            if (sPipe == null || sPipe == "")
            {
                Console.WriteLine("This class is used for WCDOOR32 mode.");
                Environment.Exit(1);  // die;
            }
#endif
        }
    }
    //------------------------------------------------------------
    // Use this class for pure CRT32 local mode operations
    //------------------------------------------------------------

    public class CWildcatLocal : CWildcatConsole
    {
        // Call the parent constructor
        public CWildcatLocal() : base()
        {
            string sPipe = Environment.GetEnvironmentVariable("wcdoorpipename");
#if DEBUG
            Console.WriteLine("CWildcatLocal.wcdoorpipename: [{0}]", Environment.GetEnvironmentVariable("wcdoorpipename"));
#endif
#if SKIP
            if (sPipe != null && sPipe != "")
            {
                Console.WriteLine("This class is used for WCCRT32 mode.");
                Environment.Exit(1);  // die;
            }
#endif
        }
    }
} //end of root namespace


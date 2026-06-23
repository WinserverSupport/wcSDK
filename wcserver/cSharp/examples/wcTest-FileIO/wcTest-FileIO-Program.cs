using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text;

using wcSDK;

namespace wcTest_FileIO
{
    class Program
    {
        public const short FILE_ATTRIBUTE_NORMAL = 0x80;
        public const short INVALID_HANDLE_VALUE = -1;
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const uint CREATE_NEW = 1;
        public const uint CREATE_ALWAYS = 2;
        public const uint OPEN_EXISTING = 3;

        static int Pause()
        {
            Console.Write("<pause>");
            ConsoleKeyInfo ci = Console.ReadKey();
            return (int) ci.Key;
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        static bool Test_GetText(string fn = "")
        {
            if (fn == null || fn.Length == 0) return false;
            string tx = wcServerAPI.GetText(fn);
            if (tx == null) return false;
            Console.WriteLine("-------------------------------- tx");
            Console.WriteLine(tx);
            Console.WriteLine("-------------------------------- tx elements");
            foreach (byte element in tx)
            {
                //Console.Write("{0}", (char)element);
                Console.WriteLine("{0} 0x{1:X}", (char)element, element);
            }
            Pause();
            byte[] data = Encoding.ASCII.GetBytes(tx);
            Console.WriteLine("-------------------------------- data");
            Console.Write(data);
            Console.WriteLine("-------------------------------- data elements");
            foreach (byte element in data)
            {
                //Console.Write("{0}", (char)element);
                Console.WriteLine("{0} 0x{1:X}", (char)element, element);
            }
            Pause();

            return true;
        }


        static void TestRead()
        {
            //String wcfn = "wc:\\wcDkim\\wcdkim-readme.txt";
            String wcfn = "wc:\\bats\\wcdoor32-hello.bbs.1";

            // works
            //String data = wcServerAPI.GetText(wcfn);
            //Console.WriteLine("{0}", data);
            int fv = wcServerAPI.WcCreateFile(wcfn, GENERIC_READ, 0, OPEN_EXISTING);
            if (fv == INVALID_HANDLE_VALUE)
            {
                Console.WriteLine("! Error {0} wcCreateFile() {1}", Marshal.GetLastWin32Error(), wcfn);
                return;
            }
            Console.WriteLine("- fv: {0} File Open: {1}", fv, wcfn);

#if TRUE
            byte[] pData = new byte[25];
            uint rd = 0;
            uint nTotal = 0;
            while (wcServerAPI.WcReadFile(fv, pData, (uint)pData.Length, ref rd) && rd > 0)
            {
                foreach (byte element in pData)
                {
                    //Console.Write("{0}", (char)element);
                    Console.WriteLine("{0} 0x{1:X}", (char)element, element);
                }
                Pause();
                nTotal += rd;
                //String s = GetString(pData);
                //Console.WriteLine(" Line size: {0} s: {1} [{2}]", rd, s.Length, s);
            }
#endif
#if FALSE
            byte[] pData = new byte[1024];
            uint nTotal = 0;
            while (wcServerAPI.WcReadLine(fv, pData, (uint)pData.Length-1)) 
            {
                String s = "";
                foreach (byte element in pData)
                {
                    nTotal++;
                    if (element == 0) break;
                    s += (char)element;
                }
                Console.WriteLine(s);
            }
            Console.WriteLine("Total Bytes: {0}", nTotal);
#endif
            wcServerAPI.WcCloseHandle(fv);
        }
        static void TestWrite()
        {

        }
        static void Main(string[] args)
        {
            if (!wcServerAPI.WildcatServerConnect(0))
            {
                return;
            }
            if (!wcServerAPI.WildcatServerCreateContext())
            {
                int err = Marshal.GetLastWin32Error();
                Console.WriteLine("! Error {0} WildcatServerCreateContext", err);
                return;
            }
            if (!wcServerAPI.LoginSystem())
            {
                int err = Marshal.GetLastWin32Error();
                Console.WriteLine("! Error {0} LoginSystem", err);
                wcServerAPI.WildcatServerDeleteContext();
                return;
            }
            Console.WriteLine("* Connected Server: {0}", wcServerAPI.GetConnectedServer());

            Test_GetText("wc:\\bats\\wcdoor32-hello.bbs.1");
            // TestRead();
            // TestWrite();

            Pause();
            wcServerAPI.WildcatServerDeleteContext();
        }
    }
}

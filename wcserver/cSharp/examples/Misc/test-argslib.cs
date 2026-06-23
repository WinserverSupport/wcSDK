//--------------------------------------------------------------
// File : C:\local\wc8\wcSDK\wcserver\c#\examples\Misc\test-argslib.cs
// Date : 05/14/20 08:22 pm
// About:
//--------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text;

using wcSDK;

namespace Test_Argslib
{
    class Program
    {
        static int Pause()
        {
            Console.Write("<pause>");
            ConsoleKeyInfo ci = Console.ReadKey();
            return (int) ci.Key;
        }

        class Arguments
        {

            string[] _args = Environment.GetCommandLineArgs();

            public Arguments()
            {
            }

            public Arguments(string[] args)
            {
            }

            public bool HasSwitch(string key)
            {
                Console.WriteLine("---------------- : [{0}]", key);

                for (int i = 0; i < _args.Length; i++)
                {
                    if (_args[i].StartsWith("/") || _args[i].StartsWith("-"))
                    {
                        string s = _args[i].Substring(1);
                        Console.WriteLine("switch{0} [{1}] key: {2}", i, s, key);
                        if (s.ToLower() == key.ToLower()) {
                                Console.WriteLine("  Key: {0}", key);
                        }
                    } else
                    {
                        Console.WriteLine("param{0} [{1}]", i, _args[i]);
                    }
                }
                return false;
            }

            string GetSwitch(string key, string def = "")
            {
               return def;
            }

            int GetInt(string key, int def = 0)
            {
                return def;
            }
            bool GetBool(string key, bool def = false) {
               return def;
            }
        }

        static void test1(string[] main_args)
        {
           string[] _args = Environment.GetCommandLineArgs();
            for (int i=0; i < _args.Length; i++)
            {
               Console.WriteLine("p: {0}", _args[i]);
            }
           Arguments args = new Arguments();

           args.HasSwitch("6");
           args.HasSwitch("2");
           args.HasSwitch("5");


        }

        static void Main(string[] args)
        {

            if (!wcServerAPI.WildcatServerConnect(0))
            {
                return;
            }
            try {
                Console.WriteLine("* Connected Server: {0}", wcServerAPI.GetConnectedServer());
                if (!wcServerAPI.WildcatServerCreateContext())
                {
                    int err = Marshal.GetLastWin32Error();
                    Console.WriteLine("! Error {0} WildcatServerCreateContext", err);
                    return;
                }
                Console.WriteLine("* Context Created. cid: {0}", wcServerAPI.GetConnectionId());
                if (!wcServerAPI.LoginSystem())
                {
                    int err = Marshal.GetLastWin32Error();
                    Console.WriteLine("! Error {0} LoginSystem", err);
                    wcServerAPI.WildcatServerDeleteContext();
                    return;
                }

                test1(args);

                Pause();
            } finally {
                wcServerAPI.WildcatServerDeleteContext();
            }
        }
    }
}


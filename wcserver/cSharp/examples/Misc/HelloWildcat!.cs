//--------------------------------------------------------------
// File : C:\local\wc8\wcSDK\wcserver\c#\examples\Misc\HelloWildcat!.cs
// Date : 05/14/20 07:14 pm
// About:
//--------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text;

using wcSDK;

namespace wcSDK_Example
{
    class Program
    {
        static int Pause()
        {
            Console.Write("<pause>");
            ConsoleKeyInfo ci = Console.ReadKey();
            return (int) ci.Key;
        }
        static void Main(string[] args)
        {

        try
        {

            if (!wcServerAPI.WildcatServerConnect(0))
            {
                return;
            }
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

            Console.WriteLine("Hello Wildcat!");

            Pause();

            wcServerAPI.WildcatServerDeleteContext();

        }

        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }

        }
    }
}


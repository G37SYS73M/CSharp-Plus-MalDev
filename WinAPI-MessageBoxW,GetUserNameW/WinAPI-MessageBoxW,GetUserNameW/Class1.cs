using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WinAPI_MessageBoxW_GetUserNameW
{
    public class Class1
    {
        [DllImport("User32.dll")]
        public static extern int MessageBoxW(
            IntPtr hWnd,
            [param: MarshalAs(UnmanagedType.LPWStr)] string lpText,
            [param: MarshalAs(UnmanagedType.LPWStr)] string lpCaptiont,
            UInt32 uType
            );

        [DllImport("Advapi32.dll")]
        public static extern bool GetUserNameW(
            [param: MarshalAs(UnmanagedType.LPWStr)] string lpBuffer,
            ref UInt32 pcbBuffer
            );
        public static void Main(string[] args) {

            int ret = MessageBoxW(IntPtr.Zero, "Hello World From Message Box", "This is the Title", 3);

            Console.ReadKey();
        }
    }
}

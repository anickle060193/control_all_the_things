using System;
using System.Runtime.InteropServices;

namespace PrototypeController
{
    static class NativeMethods
    {
        public static readonly int HWND_BROADCAST = 0xFFFF;
        public static readonly int WM_SHOWME = RegisterWindowMessage( "WM_SHOWME" );

        [DllImport( "user32" )]
        public static extern bool PostMessage( IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam );

        [DllImport( "user32" )]
        public static extern int RegisterWindowMessage( String message );
    }
}

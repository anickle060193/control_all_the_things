using System;
using System.Threading;
using System.Windows.Forms;
using ControlAllTheThings;

namespace PrototypeController
{
    static class Program
    {
        private static readonly Mutex _mutex = new Mutex( true, "D4168C28-4A41-4CFA-BD75-4A77517E1415" );

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if !DEBUG
            try
            {
#endif
                if( _mutex.WaitOne( 0, true ) )
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault( false );
                    Application.Run( new PrototypeControllerForm() );
                    _mutex.ReleaseMutex();
                }
                else
                {
                    NativeMethods.PostMessage( (IntPtr)NativeMethods.HWND_BROADCAST, NativeMethods.WM_SHOWME, IntPtr.Zero, IntPtr.Zero );
                }
#if !DEBUG
            }
            catch( Exception e )
            {
                MessageBox.Show( "The following error has occured:\n" + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
#endif
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
#if DEBUG
            Application.Run( new PrototypeControllerForm() );
#else
            try
            {
                Application.Run( new PrototypeControllerForm() );
            }
            catch( Exception e )
            {
                MessageBox.Show( "The following error has occured:\n" + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
#endif
        }
    }
}

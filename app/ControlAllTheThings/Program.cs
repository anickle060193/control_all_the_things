using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAllTheThings
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
            Application.Run( new ControlAllTheThingsForm() );
#else
            try
            {
                Application.Run( new ControlAllTheThingsForm() );
            }
            catch( Exception e )
            {
                MessageBox.Show( "The following error has occured:\n" + e.ToString(), "An Exception has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
#endif
        }
    }
}

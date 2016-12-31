using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAllTheThings.BoardActions
{
    class RunCommandBoardAction : BoardAction
    {
        public String FileName { get; private set; }
        public String Arguments { get; private set; }

        public RunCommandBoardAction( String fileName, String arguments )
        {
            FileName = fileName;
            Arguments = arguments;
        }

        public override void Perform( BoardInterface b )
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo( FileName, Arguments );
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                Process p = Process.Start( startInfo );
                p.WaitForExit();
                String stdout = p.StandardOutput.ReadToEnd();
                if( !String.IsNullOrWhiteSpace( stdout ) )
                {
                    MessageBox.Show( stdout );
                }
            }
            catch( Win32Exception e )
            {
                MessageBox.Show( String.Format( "An error occured while running the command: \"{0} {1}\"\n{2}", FileName, Arguments, e ) );
            }
        }

        public override bool Valid( BoardInterface b )
        {
            return true;
        }
    }
}

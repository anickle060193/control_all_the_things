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
            Logger.Log( "RunCommandAction: FileName: \"{0}\" Arguments: \"{1}\"", FileName, Arguments );
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
                    Logger.Log( "RunCommandAction: Output:\n{0}", stdout );
                    MessageBox.Show( stdout );
                }
            }
            catch( Win32Exception e )
            {
                String message = String.Format( "An error occured while running the command: FileName: \"{0}\" Arguments: \"{1}\"\n{2}", FileName, Arguments, e );
                Logger.Log( message );
                MessageBox.Show( message );
            }
        }

        public override bool Valid( BoardInterface b )
        {
            return true;
        }

        public override string ToString()
        {
            return String.Format( "RunCommand( FileName=\"{0}\", Arguments=\"{1}\" )", FileName, Arguments );
        }
    }
}

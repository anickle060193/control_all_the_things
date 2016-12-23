using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAllTheThings
{
    public partial class ControlAllTheThingsForm : Form
    {
        private static readonly int BAUD_RATE = 9600;

        enum MessageCommand
        {
            Identify
        }

        enum MessageBytes
        {
            StartOfMessage,
            Command,
            Pin,
            Value,
            EndOfMessage,

            Length
        }

        private static readonly byte START_OF_MESSAGE_BYTE = Convert.ToByte( 16 );
        private static readonly byte END_OF_MESSAGE_BYTE = Convert.ToByte( 4 );

        public ControlAllTheThingsForm()
        {
            InitializeComponent();
        }

        private void WaitForBoard()
        {
            while( true )
            {
                try
                {
                    foreach( String port in SerialPort.GetPortNames() )
                    {
                        using( SerialPort p = new SerialPort( port, BAUD_RATE ) )
                        {
                            if( DetectBoard( p ) )
                            {
                                MessageBox.Show( "Found board. Port: " + port );
                                return;
                            }
                        }
                    }
                }
                catch( IOException e )
                {
                    MessageBox.Show( "The following error has occured:\n" + e.ToString() );
                }
                Thread.Sleep( 1000 );
            }
        }

        private byte[] CreateMessage( MessageCommand c )
        {
            byte[] message = new byte[ (int)MessageBytes.Length ];
            message[ (int)MessageBytes.StartOfMessage ] = START_OF_MESSAGE_BYTE;
            message[ (int)MessageBytes.Command ] = Convert.ToByte( c );
            message[ (int)MessageBytes.Pin ] = Convert.ToByte( 0 );
            message[ (int)MessageBytes.Value ] = Convert.ToByte( 0 );
            message[ (int)MessageBytes.EndOfMessage ] = END_OF_MESSAGE_BYTE;
            return message;
        }

        private bool DetectBoard( SerialPort p )
        {
            byte[] message = CreateMessage( MessageCommand.Identify );

            try
            {
                p.ReadTimeout = 20000;
                p.Open();
                
                p.Write( message, 0, message.Length );

                String response = p.ReadLine().TrimEnd( '\r' );
                if( response.Equals( "Control All The Things" ) )
                {
                    return true;
                }
            }
            catch( TimeoutException )
            {

            }
            catch( IOException )
            {

            }
            finally
            {
                p.Close();
            }

            return false;
        }

        private void WaitForBoardBtn_Click( object sender, EventArgs e )
        {
            WaitForBoard();
        }
    }
}

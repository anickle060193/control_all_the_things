using CommandMessenger;
using CommandMessenger.Transport;
using CommandMessenger.Transport.Serial;
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
        private readonly BoardInterface _board;

        public ControlAllTheThingsForm()
        {
            InitializeComponent();

            _board = new BoardInterface( this );
            _board.Log += Board_Log;
            _board.PinSet += Board_PinSet;
        }

        private void Board_PinSet( object sender, PinSetEventArgs e )
        {
            switch( e.Pin )
            {
                case 12:
                    Pin12ButtonComponent.Pressed = e.State;
                    break;
            }
        }

        private void Board_Log( object sender, LogEventArgs e )
        {
            LogTextBox.Invoke( (Action)( () => LogTextBox.AppendText( e.Message + "\n" ) ) );
        }

        private void LedCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            _board.SetLed( LedCheckBox.Checked );
        }
    }
}

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
            _board.Connected += Board_Connected;
            _board.Disconnected += Board_Disconnected;
            _board.Log += Board_Log;
            _board.PinSet += Board_PinSet;
        }

        private void Board_Connected( object sender, EventArgs e )
        {
            ConnectionStateTextBox.Text = "Connected";
        }

        private void Board_Disconnected( object sender, EventArgs e )
        {
            ConnectionStateTextBox.Text = "Disconnected";
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
            LogTextBox.AppendText( e.Message + "\n" );
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
        }
    }
}

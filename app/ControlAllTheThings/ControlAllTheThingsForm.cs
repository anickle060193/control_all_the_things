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
        enum Command
        {
            Identify,
            SetLed,
            BlinkLed,
            SetPin
        }

        private const String COMMUNICATION_IDENTIFIER = "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD";

        private readonly ITransport _transport;
        private readonly CmdMessenger _messenger;
        private readonly ConnectionManager _connectionManager;

        public ControlAllTheThingsForm()
        {
            InitializeComponent();

            _transport = new SerialTransport()
            {
                CurrentSerialSettings = { DtrEnable = false }
            };

            _messenger = new CmdMessenger( _transport, BoardType.Bit16 )
            {
                PrintLfCr = false,
                ControlToInvokeOn = this
            };
            _messenger.NewLineReceived += OnNewLineReceived;
            _messenger.NewLineSent += OnNewLineSent;

            AttachCommandHandlers();

            _connectionManager = new SerialConnectionManager( _transport as SerialTransport, _messenger, (int)Command.Identify, COMMUNICATION_IDENTIFIER )
            {
                WatchdogEnabled = true
            };
            _connectionManager.Progress += ConnectionManager_Progress;
            _connectionManager.ConnectionFound += ConnectionManager_ConnectionFound;
            _connectionManager.ConnectionTimeout += ConnectionManager_ConnectionTimeout;
            _connectionManager.StartConnectionManager();
        }

        private void ConnectionManager_Progress( object sender, ConnectionManagerProgressEventArgs e )
        {
        }

        private void ConnectionManager_ConnectionFound( object sender, EventArgs e )
        {
            var command = new SendCommand( (int)Command.BlinkLed );
            _messenger.SendCommand( command );
        }

        private void ConnectionManager_ConnectionTimeout( object sender, EventArgs e )
        {
            LogTextBox.AppendText( "+-- Connection Timeout --+" );
        }

        private void LedCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            _messenger.SendCommand( new SendCommand( (int)Command.SetLed, LedCheckBox.Checked ) );
        }

        private static String FormatCommand( CommandMessenger.Command c )
        {
            return String.Format( "{0} - {1}", Enum.GetName( typeof( Command ), c.CmdId ), String.Join( " ", c.Arguments ) );
        }

        private void OnUnknownCommand( ReceivedCommand args )
        {
            LogTextBox.AppendText( String.Format( "\nUnknown command: {0}\n", FormatCommand( args ) ) );
        }

        private void OnNewLineReceived( object sender, CommandEventArgs e )
        {
            if( e.Command.CmdId != (int)Command.Identify )
            {
                LogTextBox.AppendText( String.Format( "@Received> {0}\n", FormatCommand( e.Command ) ) );
            }
        }

        private void OnNewLineSent( object sender, CommandEventArgs e )
        {
            if( e.Command.CmdId != (int)Command.Identify )
            {
                LogTextBox.AppendText( String.Format( "@Sent> {0}\n", FormatCommand( e.Command ) ) );
            }
        }

        private void AttachCommandHandlers()
        {
            _messenger.Attach( OnUnknownCommand );
            _messenger.Attach( (int)Command.SetPin, OnSetPin );
        }

        private void OnSetPin( ReceivedCommand args )
        {
            int pin = args.ReadInt16Arg();
            switch( pin )
            {
                case 12:
                    Pin12ButtonComponent.Pressed = args.ReadBoolArg();
                    break;
            }
        }
    }
}

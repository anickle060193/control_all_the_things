using CommandMessenger;
using CommandMessenger.Transport;
using CommandMessenger.Transport.Serial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAllTheThings
{
    public class LogEventArgs : EventArgs
    {
        public String Message { get; private set; }

        public LogEventArgs( String message )
        {
            Message = message;
        }
    }

    public class PinSetEventArgs : EventArgs
    {
        public int Pin { get; private set; }
        public bool State { get; private set; }

        public PinSetEventArgs( int pin, bool state )
        {
            Pin = pin;
            State = state;
        }
    }

    public class BoardInterface
    {
        public delegate void LogHandler( object sender, LogEventArgs e );
        public delegate void PinSetHandler( object sender, PinSetEventArgs e );

        public event LogHandler Log;
        public event PinSetHandler PinSet;

        private enum Command
        {
            Identify,
            Debug,
            SetLed,
            BlinkLed,
            PinSet
        }

        private const String COMMUNICATION_IDENTIFIER = "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD";

        private readonly ITransport _transport;
        private readonly CmdMessenger _messenger;
        private readonly ConnectionManager _connectionManager;

        public BoardInterface( Control c )
        {
            _transport = new SerialTransport()
            {
                CurrentSerialSettings = { DtrEnable = false }
            };

            _messenger = new CmdMessenger( _transport, BoardType.Bit16 )
            {
                PrintLfCr = false,
                // ControlToInvokeOn = c
            };
            _messenger.NewLineReceived += Messenger_NewLineReceived;
            _messenger.NewLineSent += Messenger_NewLineSent;

            _messenger.Attach( Messenger_UnknownCommand );
            _messenger.Attach( (int)Command.PinSet, Messenger_PinSetCommand );
            _messenger.Attach( (int)Command.Debug, Messenger_DebugCommand );

            _connectionManager = new SerialConnectionManager( _transport as SerialTransport, _messenger, (int)Command.Identify, COMMUNICATION_IDENTIFIER )
            {
                WatchdogEnabled = true
            };
            _connectionManager.Progress += ConnectionManager_Progress;
            _connectionManager.ConnectionFound += ConnectionManager_ConnectionFound;
            _connectionManager.ConnectionTimeout += ConnectionManager_ConnectionTimeout;
            _connectionManager.StartConnectionManager();
        }

        public void SetLed( bool state )
        {
            _messenger.SendCommand( new SendCommand( (int)Command.SetLed, state ) );
        }

        private void OnLog( String message )
        {
            if( Log != null )
            {
                Log( this, new LogEventArgs( message ) );
            }
        }

        private void OnPinSet( int pin, bool state )
        {
            if( PinSet != null )
            {
                PinSet( this, new PinSetEventArgs( pin, state ) );
            }
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
            OnLog( "+-- Connection Timeout --+" );
        }

        private static String FormatCommand( CommandMessenger.Command c )
        {
            return String.Format( "{0} - {1}", Enum.GetName( typeof( Command ), c.CmdId ), String.Join( " ", c.Arguments ) );
        }

        private void Messenger_NewLineReceived( object sender, CommandEventArgs e )
        {
            if( e.Command.CmdId != (int)Command.Identify )
            {
                OnLog( String.Format( "@Received> {0}", FormatCommand( e.Command ) ) );
            }
        }

        private void Messenger_NewLineSent( object sender, CommandEventArgs e )
        {
            if( e.Command.CmdId != (int)Command.Identify )
            {
                OnLog( String.Format( "@Sent> {0}", FormatCommand( e.Command ) ) );
            }
        }

        private void Messenger_UnknownCommand( ReceivedCommand args )
        {
            OnLog( String.Format( "\nUnknown command: {0}", FormatCommand( args ) ) );
        }

        private void Messenger_PinSetCommand( ReceivedCommand args )
        {
            int pin = args.ReadInt16Arg();
            bool state = args.ReadBoolArg();
            OnPinSet( pin, state );
        }

        private void Messenger_DebugCommand( ReceivedCommand receivedCommand )
        {
            OnLog( receivedCommand.ReadStringArg() );
        }
    }
}

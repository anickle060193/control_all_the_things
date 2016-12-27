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

    public class BoardInterface : IDisposable
    {
        private static readonly bool VERBOSE = false;

        public delegate void LogHandler( object sender, LogEventArgs e );
        public delegate void PinSetHandler( object sender, PinSetEventArgs e );

        public event LogHandler Log;
        public event PinSetHandler PinSet;
        public event EventHandler Connected;
        public event EventHandler Disconnected;

        private enum Command
        {
            Watchdog,
            Connected,
            CreateButton,
            Initialize,
            InitializationFinished,
            Debug,
            SetLed,
            PinSet
        }

        private const String COMMUNICATION_IDENTIFIER = "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD";

        private readonly ITransport _transport;
        private readonly CmdMessenger _messenger;
        private readonly ConnectionManager _connectionManager;

        public bool IsConnected { get; private set; }
        public bool Initializing { get; private set; }

        public BoardInterface( Control c )
        {
            _transport = new SerialTransport()
            {
                CurrentSerialSettings = { DtrEnable = false }
            };

            _messenger = new CmdMessenger( _transport, BoardType.Bit16 )
            {
                PrintLfCr = false,
                ControlToInvokeOn = c
            };
            _messenger.NewLineReceived += Messenger_NewLineReceived;
            _messenger.NewLineSent += Messenger_NewLineSent;

            _messenger.Attach( Messenger_UnknownCommand );
            _messenger.Attach( (int)Command.Debug, Messenger_DebugCommand );
            _messenger.Attach( (int)Command.InitializationFinished, Messenger_InitialzationFinishedCommand );
            _messenger.Attach( (int)Command.PinSet, Messenger_PinSetCommand );

            _connectionManager = new SerialConnectionManager( _transport as SerialTransport, _messenger, (int)Command.Watchdog, COMMUNICATION_IDENTIFIER )
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

        public void CreateButton( int pin )
        {
            _messenger.SendCommand( new SendCommand( (int)Command.CreateButton, pin ) );
        }

        private void OnConnected()
        {
            IsConnected = true;

            _messenger.SendCommand( new SendCommand( (int)Command.Connected ) );

            if( Connected != null )
            {
                Connected( this, EventArgs.Empty );
            }

            Initializing = true;
            OnLog( "+----- Initializing -----+" );
            _messenger.SendCommand( new SendCommand( (int)Command.Initialize ) );
        }

        private void OnDisconnected()
        {
            IsConnected = false;

            if( Disconnected != null )
            {
                Disconnected( this, EventArgs.Empty );
            }
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
            if( VERBOSE )
            {
                OnLog( e.Description );
            }
        }

        private void ConnectionManager_ConnectionFound( object sender, EventArgs e )
        {
            OnConnected();
        }

        private void ConnectionManager_ConnectionTimeout( object sender, EventArgs e )
        {
            OnDisconnected();
        }

        private static String FormatCommand( CommandMessenger.Command c )
        {
            return String.Format( "{0} - {1}", Enum.GetName( typeof( Command ), c.CmdId ), String.Join( " ", c.Arguments ) );
        }

        private void Messenger_NewLineReceived( object sender, CommandEventArgs e )
        {
            if( VERBOSE || e.Command.CmdId != (int)Command.Watchdog )
            {
                OnLog( String.Format( "@Received> {0}", FormatCommand( e.Command ) ) );
            }
        }

        private void Messenger_NewLineSent( object sender, CommandEventArgs e )
        {
            if( VERBOSE || e.Command.CmdId != (int)Command.Watchdog )
            {
                OnLog( String.Format( "@Sent> {0}", FormatCommand( e.Command ) ) );
            }
        }

        private void Messenger_UnknownCommand( ReceivedCommand args )
        {
            OnLog( String.Format( "\nUnknown command: {0}", FormatCommand( args ) ) );
        }

        private void Messenger_DebugCommand( ReceivedCommand args )
        {
            OnLog( args.ReadStringArg() );
        }

        private void Messenger_InitialzationFinishedCommand( ReceivedCommand args )
        {
            Initializing = false;
            OnLog( "+----- Initialization Finished -----+" );
        }

        private void Messenger_PinSetCommand( ReceivedCommand args )
        {
            int pin = args.ReadInt16Arg();
            bool state = args.ReadBoolArg();
            OnPinSet( pin, state );
        }

        public void Dispose()
        {
            _messenger.Disconnect();
            _messenger.Dispose();
            _transport.Dispose();
        }
    }
}

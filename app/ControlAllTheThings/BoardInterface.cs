using CommandMessenger;
using CommandMessenger.Transport;
using CommandMessenger.Transport.Serial;
using System;
using System.Collections.Generic;
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
        public NamedPin Pin { get; private set; }
        public bool State { get; private set; }

        public PinSetEventArgs( NamedPin pin, bool state )
        {
            Pin = pin;
            State = state;
        }
    }

    public class BoardInterface : IDisposable
    {
        private static readonly bool VERBOSE = false;

        public enum PinMode
        {
            Input = 0,
            Output = 1,
            InputPullup = 2
        }

        public delegate void LogHandler( object sender, LogEventArgs e );
        public delegate void PinSetHandler( object sender, PinSetEventArgs e );

        public event LogHandler Log;
        public event PinSetHandler PinSet;
        public event EventHandler Connected;
        public event EventHandler InitializationComplete;
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
            SetPinMode,
            SetPin,
            TogglePin,
            PinSet
        }

        private const String COMMUNICATION_IDENTIFIER = "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD";

        private readonly ITransport _transport;
        private readonly CmdMessenger _messenger;
        private readonly ConnectionManager _connectionManager;

        public List<NamedPin> OutputPins { get; private set; }
        public List<NamedPin> InputPins { get; private set; }

        public bool IsConnected { get; private set; }
        public bool Initializing { get; private set; }

        public BoardInterface( Control c )
        {
            OutputPins = new List<NamedPin>();
            InputPins = new List<NamedPin>();

            _transport = new SerialTransport()
            {
                CurrentSerialSettings = { DtrEnable = false, BaudRate = 9600 }
            };

            _messenger = new CmdMessenger( _transport, BoardType.Bit32 )
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
                WatchdogEnabled = true,
                DeviceScanBaudRateSelection = false
            };
            _connectionManager.Progress += ConnectionManager_Progress;
            _connectionManager.ConnectionFound += ConnectionManager_ConnectionFound;
            _connectionManager.ConnectionTimeout += ConnectionManager_ConnectionTimeout;
        }

        public void Start()
        {
            Logger.Log( "Staring ConnectionManager" );
            _connectionManager.StartConnectionManager();
        }

        public void StartInitialization()
        {
            Initializing = true;

            Logger.Log( "Initialization Started" );
            OnLog( "+----- Initialization Started -----+" );

            Logger.Log( "Sending Initialize()" );
            _messenger.SendCommand( new SendCommand( (int)Command.Initialize ) );
        }

        #region Command Senders

        public void SetLed( bool state )
        {
            Logger.Log( "Sending SetLed( State={0} )", state );
            _messenger.SendCommand( new SendCommand( (int)Command.SetLed, state ) );
        }

        public void SetPin( NamedPin pin, bool state )
        {
            Logger.Log( "Sending SetPin( Pin={0}, State={1} )", pin, state );
            var c = new SendCommand( (int)Command.SetPin );
            c.AddArgument( pin.Pin );
            c.AddArgument( state );
            _messenger.SendCommand( c );
        }

        public void TogglePin( NamedPin pin )
        {
            Logger.Log( "Sending TogglePin( Pin={0} )", pin );
            _messenger.SendCommand( new SendCommand( (int)Command.TogglePin, pin.Pin ) );
        }

        private void CreateButton( NamedPin pin )
        {
            Logger.Log( "Sending CreateButton( Pin={0} )", pin );
            _messenger.SendCommand( new SendCommand( (int)Command.CreateButton, pin.Pin ) );
        }

        private void SetPinMode( NamedPin pin, PinMode mode )
        {
            Logger.Log( "Sending SetPinMode( Pin={0}, PinMode={1} )", pin, mode );
            var c = new SendCommand( (int)Command.SetPinMode );
            c.AddArgument( pin.Pin );
            c.AddArgument( (int)mode );
            _messenger.SendCommand( c );
        }

        #endregion

        #region Event Triggerers

        private void OnConnected()
        {
            Logger.Log( "OnConnected" );
            IsConnected = true;

            Logger.Log( "Sending Connected()" );
            _messenger.SendCommand( new SendCommand( (int)Command.Connected ) );

            foreach( NamedPin inputPin in InputPins )
            {
                CreateButton( inputPin );
            }

            foreach( NamedPin outputPin in OutputPins )
            {
                SetPinMode( outputPin, PinMode.Output );
            }

            Connected?.Invoke( this, EventArgs.Empty );
        }

        private void OnDisconnected()
        {
            IsConnected = false;
            Logger.Log( "OnDisconnected" );

            Disconnected?.Invoke( this, EventArgs.Empty );
        }

        private void OnLog( String message )
        {
            Log?.Invoke( this, new LogEventArgs( message ) );
        }

        private void OnPinSet( NamedPin pin, bool state )
        {
            Logger.Log( "OnPinSet( Pin={0}, State={1} )", pin, state );
            PinSet?.Invoke( this, new PinSetEventArgs( pin, state ) );
        }

        #endregion

        #region Messenger Event Handlers

        private void ConnectionManager_Progress( object sender, ConnectionManagerProgressEventArgs e )
        {
            Logger.Log( "ConnectionManager Progress - {0}", e.Description );
            if( VERBOSE || !IsConnected )
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
            String message = String.Format( "@Received> {0}", FormatCommand( e.Command ) );
            Logger.Log( message );
            if( VERBOSE || e.Command.CmdId != (int)Command.Watchdog || !IsConnected )
            {
                OnLog( message );
            }
        }

        private void Messenger_NewLineSent( object sender, CommandEventArgs e )
        {
            String message = String.Format( "@Sent> {0}", FormatCommand( e.Command ) );
            Logger.Log( message );
            if( VERBOSE || e.Command.CmdId != (int)Command.Watchdog || !IsConnected )
            {
                OnLog( message );
            }
        }

        #endregion

        #region Messenger Command Handlers

        private void Messenger_UnknownCommand( ReceivedCommand args )
        {
            String message = String.Format( "\nUnknown command: {0}", FormatCommand( args ) );
            Logger.Log( message );
            OnLog( message );
        }

        private void Messenger_DebugCommand( ReceivedCommand args )
        {
            String debug = args.ReadStringArg();
            Logger.Log( debug );
            OnLog( debug );
        }

        private void Messenger_InitialzationFinishedCommand( ReceivedCommand args )
        {
            Initializing = false;
            Logger.Log( "Initialization Finished" );
            OnLog( "+----- Initialization Finished -----+" );
            InitializationComplete?.Invoke( this, EventArgs.Empty );
        }

        private void Messenger_PinSetCommand( ReceivedCommand args )
        {
            int pin = args.ReadInt16Arg();
            bool state = args.ReadBoolArg();

            NamedPin p = NamedPin.GetNamedPin( pin );

            OnPinSet( p, state );
        }

        #endregion

        public void Dispose()
        {
            _messenger.Disconnect();
            _messenger.Dispose();
            _transport.Dispose();
        }
    }
}

using CommandMessenger;
using CommandMessenger.Transport;
using CommandMessenger.Transport.Serial;
using ControlAllTheThings.BoardActions;
using ControlAllTheThings.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private static readonly int[] LED_PINS = { 1, 3, 6, 9, 14, 16, 19, 22 };

        private readonly Dictionary<int, ButtonComponent> _buttons = new Dictionary<int, ButtonComponent>();

        private readonly BoardInterface _board;
        private readonly NotifyIcon _notifyIcon;

        public ControlAllTheThingsForm()
        {
            InitializeComponent();

            _board = new BoardInterface( this );
            _board.Connected += Board_Connected;
            _board.Disconnected += Board_Disconnected;
            _board.Log += Board_Log;
            _board.PinSet += Board_PinSet;

            _buttons.Add(  0, YellowButton );
            _buttons.Add(  4, GreenButton );
            _buttons.Add(  7, BlueButton );
            _buttons.Add( 11, WhiteButton );
            _buttons.Add( 23, YellowLatch );
            _buttons.Add( 20, GreenLatch );
            _buttons.Add( 17, BlueLatch );
            _buttons.Add( 15, WhiteLatch );

            foreach( KeyValuePair<int, ButtonComponent> pb in _buttons )
            {
                pb.Value.Pin = pb.Key;
                pb.Value.BoardInterface = _board;
            }

            LoadSettings();

            _notifyIcon = CreateNotifyIcon();

            this.FormClosed += ( sender, e ) => SaveSettings();
            this.LostFocus += ( sender, e ) => SaveSettings();

            _board.InputPins.AddRange( _buttons.Keys );
            _board.OutputPins.AddRange( LED_PINS );

            _board.Start();
        }

        private void LoadSettings()
        {
            try
            {
                if( File.Exists( "settings.json" ) )
                {
                    String s = null;
                    using( StreamReader r = new StreamReader( "settings.json" ) )
                    {
                        s = r.ReadToEnd();
                    }
                    Settings settings = JsonConvert.DeserializeObject<Settings>( s );
                    foreach( ButtonComponent b in _buttons.Values )
                    {
                        if( settings.ContainsKey( b.Name ) )
                        {
                            ButtonSettings bs = settings[ b.Name ];
                            b.PressedAction = BoardAction.FromSetting( bs.PressedActionSetting );
                            b.UnpressedAction = BoardAction.FromSetting( bs.UnpressedActionSetting );
                        }
                    }
                }
            }
            catch( IOException ) { }
            catch( JsonException ) { }
        }

        private void SaveSettings()
        {
            try
            {
                Settings settings = new Settings();
                foreach( ButtonComponent b in _buttons.Values )
                {
                    settings.AddButtonSettings( b.Name )
                        .SetPressedAction( BoardAction.ToSetting( b.PressedAction ) )
                        .SetUnpressedAction( BoardAction.ToSetting( b.UnpressedAction ) );
                }
                String s = JsonConvert.SerializeObject( settings, Formatting.Indented );
                using( StreamWriter w = new StreamWriter( "settings.json" ) )
                {
                    w.Write( s );
                }
            }
            catch( IOException ) { }
            catch( JsonException ) { }
        }

        private NotifyIcon CreateNotifyIcon()
        {
            NotifyIcon icon = new NotifyIcon();
            icon.Visible = true;
            icon.Text = "Not Connected";
            icon.Icon = SystemIcons.Application;
            icon.DoubleClick += ( sender, e ) => this.Show();

            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add( "Exit" ).Click += ( sender, e ) => Application.Exit();
            icon.ContextMenu = menu;

            return icon;
        }

        #region Board Interface Event Handlers

        private void Board_Connected( object sender, EventArgs e )
        {
            ConnectionStatusLabel.Text = "Connected";
            _notifyIcon.Text = "Connected";
            _notifyIcon.Icon = SystemIcons.Application;
            ConnectionStatusProgressBar.Style = ProgressBarStyle.Continuous;
        }

        private void Board_Disconnected( object sender, EventArgs e )
        {
            ConnectionStatusLabel.Text = "Disconnected";
            _notifyIcon.Text = "Disconnected";
            _notifyIcon.Icon = SystemIcons.Warning;
            ConnectionStatusProgressBar.Style = ProgressBarStyle.Marquee;
        }

        private void Board_PinSet( object sender, PinSetEventArgs e )
        {
            ButtonComponent b;
            if( _buttons.TryGetValue( e.Pin, out b ) )
            {
                b.Pressed = e.State;
            }
        }

        private void Board_Log( object sender, LogEventArgs e )
        {
            LogTextBox.AppendText( String.Format( "[{0:MM/dd/yy hh:mm:ss.ff tt}] {1}{2}", DateTime.Now, e.Message, Environment.NewLine ) );
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
        }

        #endregion

        #region Form Event Handlers

        protected override void OnClosed( EventArgs e )
        {
            base.OnClosed( e );

            _board.Dispose();
        }

        private void Exit_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void ControlAllTheThingsForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            if( e.CloseReason == CloseReason.UserClosing )
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ViewLogFileMenuItem_Click( object sender, EventArgs e )
        {
            Process.Start( "explorer.exe", String.Format( "/select,{0}", _board.Logger.FileName ) );
        }

        #endregion
    }
}

using CommandMessenger;
using CommandMessenger.Transport;
using CommandMessenger.Transport.Serial;
using ControlAllTheThings.BoardActions;
using ControlAllTheThings.BoardComponents;
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
using System.Reflection;
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

            Logger.Init();

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

            _notifyIcon = CreateNotifyIcon();

            this.FormClosed += ( sender, e ) => SaveSettings();

            _board.InputPins.AddRange( _buttons.Keys );
            _board.OutputPins.AddRange( LED_PINS );

            LoadSettings();

            _board.Start();
        }

        private void LoadSettings()
        {
            RunOnStartup.Checked = File.Exists( GetStartupShortcutLocation() );

            MinimizeToSystemTrayMenuItem.Checked = Properties.Settings.Default.MinimizeToSystemTray;
            String settingsFileLocation = Properties.Settings.Default.SettingsFileLocation;
            SettingsFileLocationDialog.FileName = settingsFileLocation;

            Settings settings = Settings.Load( settingsFileLocation );
            if( settings != null )
            {
                foreach( ButtonComponent b in _buttons.Values )
                {
                    b.LoadSettings( settings );
                }
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.MinimizeToSystemTray = MinimizeToSystemTrayMenuItem.Checked;
            Properties.Settings.Default.Save();

            Settings settings = new Settings();
            foreach( ButtonComponent b in _buttons.Values )
            {
                b.SaveSettings( settings );
            }
            settings.Save( Properties.Settings.Default.SettingsFileLocation );
        }

        private NotifyIcon CreateNotifyIcon()
        {
            NotifyIcon icon = new NotifyIcon();
            icon.Visible = true;
            icon.Text = "Not Connected";
            icon.Icon = SystemIcons.Application;
            icon.DoubleClick += NotifyIcon_DoubleClick;

            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add( "Exit" ).Click += Exit_Click;
            icon.ContextMenu = menu;

            return icon;
        }

        private String GetStartupShortcutLocation()
        {
            return Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.Startup ), "ControlAllTheThings.lnk" );
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
            Logger.Close();
        }

        private void Exit_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void ViewLogFileMenuItem_Click( object sender, EventArgs e )
        {
            String logFileName = Logger.GetFileName();
            if( logFileName != null )
            {
                Process.Start( "explorer.exe", String.Format( "/select,{0}", Logger.GetFileName() ) );
            }
        }

        private void ChooseSettingsLocation_Click( object sender, EventArgs e )
        {
            if( SettingsFileLocationDialog.ShowDialog() == DialogResult.OK )
            {
                String saveFileLocation = SettingsFileLocationDialog.FileName;

                Properties.Settings.Default.SettingsFileLocation = SettingsFileLocationDialog.FileName;
                Properties.Settings.Default.Save();

                if( File.Exists( saveFileLocation ) )
                {
                    if( MessageBox.Show( "Load settings now?", "Settings", MessageBoxButtons.YesNo ) == DialogResult.Yes )
                    {
                        LoadSettings();
                    }
                }
            }
        }

        private void NotifyIcon_DoubleClick( object sender, EventArgs e )
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ControlAllTheThingsForm_Resize( object sender, EventArgs e )
        {
            if( MinimizeToSystemTrayMenuItem.Checked )
            {
                if( this.WindowState == FormWindowState.Minimized )
                {
                    this.Hide();
                }
            }
            Properties.Settings.Default.Save();
        }

        private void RunOnStartup_CheckedChanged( object sender, EventArgs e )
        {
            String shortcutAddress = GetStartupShortcutLocation();
            if( RunOnStartup.Checked )
            {
                Assembly assembly = Assembly.GetEntryAssembly();
                String targetPath = Path.GetFullPath( new Uri( assembly.CodeBase ).LocalPath );
                String workingDirectory = Path.GetDirectoryName( targetPath );
                var shell = new IWshRuntimeLibrary.WshShell();
                var shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut( shortcutAddress );
                shortcut.TargetPath = targetPath;
                shortcut.WorkingDirectory = workingDirectory;
                shortcut.Save();
            }
            else
            {
                File.Delete( shortcutAddress );
            }
        }

        #endregion
    }
}

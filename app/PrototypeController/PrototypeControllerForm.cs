using ControlAllTheThings;
using ControlAllTheThings.BoardComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace PrototypeController
{
    public partial class PrototypeControllerForm : Form
    {
        private readonly List<BaseComponent> _components = new List<BaseComponent>();

        private readonly BoardInterface _board;
        private readonly NotifyIcon _notifyIcon;

        public PrototypeControllerForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.PrototypeControllerIcon;

            WhiteLatch.Pin = NamedPin.CreateNamedPin( 15, "White Latch" );
            WhiteLatch.LedPin = NamedPin.CreateNamedPin( 14, "White Latch LED" );

            BlueLatch.Pin = NamedPin.CreateNamedPin( 17, "Blue Latch" );
            BlueLatch.LedPin = NamedPin.CreateNamedPin( 16, "Blue Latch LED" );

            GreenLatch.Pin = NamedPin.CreateNamedPin( 20, "Green Latch" );
            GreenLatch.LedPin = NamedPin.CreateNamedPin( 19, "Green Latch LED" );

            YellowLatch.Pin = NamedPin.CreateNamedPin( 23, "Yellow Latch" );
            YellowLatch.LedPin = NamedPin.CreateNamedPin( 22, "Yellow Latch LED" );

            WhiteButton.Pin = NamedPin.CreateNamedPin( 11, "White Button" );
            WhiteButton.LedPin = NamedPin.CreateNamedPin( 9, "White Button LED" );

            BlueButton.Pin = NamedPin.CreateNamedPin( 7, "Blue Button" );
            BlueButton.LedPin = NamedPin.CreateNamedPin( 6, "Blue Button LED" );

            GreenButton.Pin = NamedPin.CreateNamedPin( 4, "Green Button" );
            GreenButton.LedPin = NamedPin.CreateNamedPin( 3, "Green Button LED" );

            YellowButton.Pin = NamedPin.CreateNamedPin( 0, "Yellow Button" );
            YellowButton.LedPin = NamedPin.CreateNamedPin( 1, "Yellow Button LED" );

            Logger.Init();

            _board = new BoardInterface( this );
            _board.Connected += Board_Connected;
            _board.Disconnected += Board_Disconnected;
            _board.Log += Board_Log;

            _components.Add( YellowButton );
            _components.Add( GreenButton );
            _components.Add( BlueButton );
            _components.Add( WhiteButton );
            _components.Add( WhiteLatch );
            _components.Add( BlueLatch );
            _components.Add( GreenLatch );
            _components.Add( YellowLatch );

            foreach( BaseComponent c in _components )
            {
                c.SetBoardInterface( _board );
            }

            _notifyIcon = CreateNotifyIcon();

            LoadSettings();

            _board.Start();
        }

        protected override void WndProc( ref Message m )
        {
            if( m.Msg == NativeMethods.WM_SHOWME )
            {
                this.Show();
                if( this.WindowState == FormWindowState.Minimized )
                {
                    this.WindowState = FormWindowState.Normal;
                }
                bool top = this.TopMost;
                this.TopMost = true;
                this.TopMost = top;
            }
            base.WndProc( ref m );
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
                foreach( BaseComponent c in _components )
                {
                    c.LoadSettings( settings );
                }
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.MinimizeToSystemTray = MinimizeToSystemTrayMenuItem.Checked;
            Properties.Settings.Default.Save();

            Settings settings = new Settings();
            foreach( BaseComponent c in _components )
            {
                c.SaveSettings( settings );
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

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Board_Startup;
            worker.RunWorkerCompleted += Board_StartupCompleted;
            worker.RunWorkerAsync();
        }

        private void Board_Startup( Object sender, DoWorkEventArgs e )
        {
            Thread.Sleep( 200 );
            for( int i = 0; i < _board.OutputPins.Count; i++ )
            {
                if( i - 1 >= 0 )
                {
                    _board.SetPin( _board.OutputPins[ i - 1 ], false );
                }
                _board.SetPin( _board.OutputPins[ i ], true );
                Thread.Sleep( 200 );
            }
            _board.SetPin( _board.OutputPins.Last(), false );
        }

        private void Board_StartupCompleted( Object sender, RunWorkerCompletedEventArgs e )
        {
            _board.StartInitialization();
        }

        private void Board_Disconnected( object sender, EventArgs e )
        {
            ConnectionStatusLabel.Text = "Disconnected";
            _notifyIcon.Text = "Disconnected";
            _notifyIcon.Icon = SystemIcons.Warning;
            ConnectionStatusProgressBar.Style = ProgressBarStyle.Marquee;
        }

        private void Board_Log( object sender, LogEventArgs e )
        {
            LogTextBox.AppendText( String.Format( "[{0:MM/dd/yy hh:mm:ss.ff tt}] {1}{2}", DateTime.Now, e.Message, Environment.NewLine ) );
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
        }

        #endregion

        #region Form Event Handlers

        private void ControlAllTheThingsForm_FormClosed( object sender, FormClosedEventArgs e )
        {
            SaveSettings();

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

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

namespace ControlAllTheThings
{
    public partial class BaseControllerForm<T> : Form where T : VirtualBoardControl, new()
    {
        private BoardInterface _board;
        private NotifyIcon _notifyIcon;
        private T _controller;

        public BaseControllerForm()
        {
            InitializeComponent();

            _controller = new T();
            _controller.Anchor = AnchorStyles.Top;

            TableLayout.Controls.Add( _controller, 0, 0 );

            this.MinimumSize = new Size( _controller.Width + 50, _controller.Height + 200 );
        }

        private void BaseControllerForm_Load( object sender, EventArgs e )
        {
            if( this.DesignMode )
            {
                return;
            }

            Logger.Init();

            _notifyIcon = CreateNotifyIcon();

            _board = new BoardInterface( this );
            _board.Connected += Board_Connected;
            _board.Disconnected += Board_Disconnected;
            _board.Log += Board_Log;

            _controller.SetBoardInterface( _board );

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
            String settingsFileLocation = Path.GetFullPath( Properties.Settings.Default.SettingsFileLocation );
            SettingsFileLocationDialog.FileName = settingsFileLocation;

            Settings settings = Settings.Load( settingsFileLocation );
            if( settings != null )
            {
                _controller.LoadSettings( settings );
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.MinimizeToSystemTray = MinimizeToSystemTrayMenuItem.Checked;
            Properties.Settings.Default.Save();

            Settings settings = new Settings();
            _controller.SaveSettings( settings );
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
            Assembly assembly = Assembly.GetEntryAssembly();
            String name = assembly.GetName().Name;
            return Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.Startup ), name + ".lnk" );
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
            if( _board.OutputPins.Count > 0 )
            {
                List<NamedPin> pins = _board.OutputPins.OrderBy( p => p.Pin ).ToList();

                Thread.Sleep( 200 );
                for( int i = 0; i < pins.Count; i++ )
                {
                    if( i - 1 >= 0 )
                    {
                        _board.SetPin( pins[ i - 1 ], false );
                    }
                    _board.SetPin( pins[ i ], true );
                    Thread.Sleep( 200 );
                }
                _board.SetPin( pins.Last(), false );
            }
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

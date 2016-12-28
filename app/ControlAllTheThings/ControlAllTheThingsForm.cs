using CommandMessenger;
using CommandMessenger.Transport;
using CommandMessenger.Transport.Serial;
using ControlAllTheThings.BoardActions;
using ControlAllTheThings.Properties;
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
        private readonly NotifyIcon _notifyIcon;

        public ControlAllTheThingsForm()
        {
            InitializeComponent();

            _board = new BoardInterface( this );
            _board.Connected += Board_Connected;
            _board.Disconnected += Board_Disconnected;
            _board.Log += Board_Log;
            _board.PinSet += Board_PinSet;

            Pin12ButtonComponent.BoardInterface = _board;
            Pin11ButtonComponent.BoardInterface = _board;

            LoadSettings();

            _notifyIcon = CreateNotifyIcon();

            this.FormClosed += ( sender, e ) => SaveSettings();
            this.LostFocus += ( sender, e ) => SaveSettings();
        }

        private void LoadSettings()
        {
            BoardAction a;
            
            a = BoardAction.FromSetting( Settings.Default.Pin12ButtonPressedAction );
            Pin12ButtonComponent.PressedAction = a;

            a = BoardAction.FromSetting( Settings.Default.Pin12ButtonUnpressedAction );
            Pin12ButtonComponent.UnpressedAction = a;

            a = BoardAction.FromSetting( Settings.Default.Pin11ButtonPressedAction );
            Pin11ButtonComponent.PressedAction = a;

            a = BoardAction.FromSetting( Settings.Default.Pin11ButtonUnpressedAction );
            Pin11ButtonComponent.UnpressedAction = a;
        }

        private void SaveSettings()
        {
            String setting;

            setting = BoardAction.ToSetting( Pin12ButtonComponent.PressedAction );
            Settings.Default.Pin12ButtonPressedAction = setting;

            setting = BoardAction.ToSetting( Pin12ButtonComponent.UnpressedAction );
            Settings.Default.Pin12ButtonUnpressedAction = setting;

            setting = BoardAction.ToSetting( Pin11ButtonComponent.PressedAction );
            Settings.Default.Pin11ButtonPressedAction = setting;

            setting = BoardAction.ToSetting( Pin11ButtonComponent.UnpressedAction );
            Settings.Default.Pin11ButtonUnpressedAction = setting;

            Settings.Default.Save();
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

        private void Board_Connected( object sender, EventArgs e )
        {
            ConnectionStatusLabel.Text = "Connected";
            _notifyIcon.Text = "Connected";
            _notifyIcon.Icon = SystemIcons.Application;
            ConnectionStatusProgressBar.Style = ProgressBarStyle.Continuous;

            _board.CreateButton( 12 );
            _board.CreateButton( 11 );
            _board.SetPinMode( 10, BoardInterface.PinMode.Output );
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
            switch( e.Pin )
            {
                case 12:
                    Pin12ButtonComponent.Pressed = e.State;
                    break;

                case 11:
                    Pin11ButtonComponent.Pressed = e.State;
                    break;
            }
        }

        private void Board_Log( object sender, LogEventArgs e )
        {
            LogTextBox.AppendText( String.Format( "[{0:MM/dd/yy hh:mm:ss.ff tt}] {1}{2}", DateTime.Now, e.Message, Environment.NewLine ) );
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
        }

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
    }
}

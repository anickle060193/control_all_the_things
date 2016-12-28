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

        private void Board_Connected( object sender, EventArgs e )
        {
            ConnectionStateTextBox.Text = "Connected";

            _board.CreateButton( 12 );
            _board.CreateButton( 11 );
            _board.SetPinMode( 10, BoardInterface.PinMode.Output );
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

                case 11:
                    Pin11ButtonComponent.Pressed = e.State;
                    break;
            }
        }

        private void Board_Log( object sender, LogEventArgs e )
        {
            LogTextBox.AppendText( e.Message + "\n" );
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
        }

        protected override void OnClosed( EventArgs e )
        {
            base.OnClosed( e );

            _board.Dispose();
        }
    }
}

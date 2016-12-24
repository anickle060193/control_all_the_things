using CommandMessenger;
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
            SetLed,
            SetPin
        }

        private readonly SerialTransport _serialTransport;
        private readonly CmdMessenger _cmdMessenger;

        public ControlAllTheThingsForm()
        {
            InitializeComponent();

            _serialTransport = new SerialTransport();
            _serialTransport.CurrentSerialSettings.PortName = "COM3";
            _serialTransport.CurrentSerialSettings.BaudRate = 115200;
            _serialTransport.CurrentSerialSettings.DtrEnable = false;

            _cmdMessenger = new CmdMessenger( _serialTransport, BoardType.Bit16 );
            _cmdMessenger.Attach( (int)Command.SetPin, OnPinSet );
            _cmdMessenger.Connect();

            _cmdMessenger.Dispose()
        }

        private void LedCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            _cmdMessenger.SendCommand( new SendCommand( (int)Command.SetLed, LedCheckBox.Checked ) );
        }

        private void OnPinSet( ReceivedCommand args )
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

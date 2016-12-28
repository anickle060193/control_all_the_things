using ControlAllTheThings.BoardActions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAllTheThings
{
    public partial class ActionForm : Form
    {
        public BoardAction Action { get; set; }

        public ActionForm( BoardAction currentAction )
        {
            InitializeComponent();

            Action = currentAction;

            DialogResult = DialogResult.Cancel;

            SetLedAction.Tag = SetLedActionOptions;
            SetPinAction.Tag = SetPinActionOptions;
            TogglePinAction.Tag = TogglePinActionOptions;

            SetLedActionOptions.Enabled = false;
            SetPinActionOptions.Enabled = false;
            TogglePinActionOptions.Enabled = false;

            SetUiFromAction();
        }

        public ActionForm() : this( null )
        {
        }

        private void SetUiFromAction()
        {
            if( Action is SetLedBoardAction )
            {
                SetLedAction.Checked = true;
                SetLedBoardAction a = Action as SetLedBoardAction;
                SetLedActionStateOption.Checked = a.SetToState;
            }
            else if( Action is SetPinBoardAction )
            {
                SetPinAction.Checked = true;
                SetPinBoardAction a = Action as SetPinBoardAction;
                SetPinActionPinOption.Value = a.Pin;
                SetPinActionStateOption.Checked = a.SetToState;
            }
            else if( Action is TogglePinBoardAction )
            {
                TogglePinAction.Checked = true;
                TogglePinBoardAction a = Action as TogglePinBoardAction;
                TogglePinActionPinOption.Value = a.Pin;
            }
        }

        private void SetActionFromUi()
        {
            if( SetLedAction.Checked )
            {
                bool setToState = SetLedActionStateOption.Checked;
                Action = new SetLedBoardAction( setToState );
            }
            else if( SetPinAction.Checked )
            {
                int pin = (int)SetPinActionPinOption.Value;
                bool setToState = SetPinActionStateOption.Checked;
                Action = new SetPinBoardAction( pin, setToState );
            }
            else if( TogglePinAction.Checked )
            {
                int pin = (int)TogglePinActionPinOption.Value;
                Action = new TogglePinBoardAction( pin );
            }
        }

        private void Ok_Click( object sender, EventArgs e )
        {
            SetActionFromUi();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void Action_CheckedChanged( object sender, EventArgs e )
        {
            RadioButton r = sender as RadioButton;
            if( r != null )
            {
                GroupBox g = r.Tag as GroupBox;
                if( g != null )
                {
                    g.Enabled = r.Checked;
                }
            }
        }
    }
}

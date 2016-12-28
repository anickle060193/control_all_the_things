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

            SetLedActionOptions.Enabled = false;
            SetPinActionOptions.Enabled = false;

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
        }

        private void OkButton_Click( object sender, EventArgs e )
        {
            SetActionFromUi();

            if( Action == null )
            {
                MessageBox.Show( "An action must be selected." );
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
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

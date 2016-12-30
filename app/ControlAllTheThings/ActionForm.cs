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
        public BoardInterface Board { get; set; }
        public BoardAction Action { get; set; }

        public ActionForm( String title, BoardAction currentAction, BoardInterface board )
        {
            InitializeComponent();

            Text = title;
            Board = board;
            Action = currentAction;

            DialogResult = DialogResult.Cancel;

            SetLedAction.Tag = SetLedActionOptions;
            SetPinAction.Tag = SetPinActionOptions;
            TogglePinAction.Tag = TogglePinActionOptions;
            NoAction.Tag = NoActionLabel;

            SetLedActionOptions.Enabled = false;
            SetPinActionOptions.Enabled = false;
            TogglePinActionOptions.Enabled = false;
            NoActionLabel.Enabled = false;

            if( Board != null )
            {
                Object[] pins = Board.OutputPins.Cast<Object>().ToArray();
                SetPinActionPinOption.Items.AddRange( pins );
                TogglePinActionPinOption.Items.AddRange( pins );
            }

            SetUiFromAction();
        }

        public ActionForm( String title, BoardInterface board ) : this( title, null, board )
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
                SetPinActionPinOption.SelectedItem = a.Pin;
                SetPinActionStateOption.Checked = a.SetToState;
            }
            else if( Action is TogglePinBoardAction )
            {
                TogglePinAction.Checked = true;
                TogglePinBoardAction a = Action as TogglePinBoardAction;
                TogglePinActionPinOption.SelectedItem = a.Pin;
            }
            else
            {
                NoAction.Checked = true;
            }
        }

        private void SetActionFromUi()
        {
            if( NoAction.Checked )
            {
                Action = null;
            }
            else if( SetLedAction.Checked )
            {
                bool setToState = SetLedActionStateOption.Checked;
                Action = new SetLedBoardAction( setToState );
            }
            else if( SetPinAction.Checked )
            {
                int pin = (int)SetPinActionPinOption.SelectedItem;
                bool setToState = SetPinActionStateOption.Checked;
                Action = new SetPinBoardAction( pin, setToState );
            }
            else if( TogglePinAction.Checked )
            {
                int pin = (int)TogglePinActionPinOption.SelectedItem;
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
                Control c = r.Tag as Control;
                if( c != null )
                {
                    c.Enabled = r.Checked;
                }
            }
        }
    }
}

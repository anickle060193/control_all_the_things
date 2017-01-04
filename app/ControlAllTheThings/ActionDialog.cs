using ControlAllTheThings.BoardActions;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ControlAllTheThings
{
    public partial class ActionDialog : Form
    {
        public BoardInterface Board { get; private set; }
        public BoardAction Action { get; private set; }

        public ActionDialog( BoardInterface board, String title, BoardAction currentAction )
        {
            InitializeComponent();

            Text = title;
            Board = board;
            Action = currentAction;

            DialogResult = DialogResult.Cancel;

            NoAction.Tag = NoActionLabel;
            SetLedAction.Tag = SetLedActionOptions;
            SetPinAction.Tag = SetPinActionOptions;
            TogglePinAction.Tag = TogglePinActionOptions;
            RunScriptAction.Tag = RunScriptActionOptions;

            NoActionLabel.Enabled = false;
            SetLedActionOptions.Enabled = false;
            SetPinActionOptions.Enabled = false;
            TogglePinActionOptions.Enabled = false;
            RunScriptActionOptions.Enabled = false;

            if( Board != null )
            {
                Object[] pins = Board.OutputPins.Cast<Object>().ToArray();
                SetPinActionPinOption.Items.AddRange( pins );
                TogglePinActionPinOption.Items.AddRange( pins );
            }
            else
            {
                TestAction.Hide();
            }

            UpdateUiForAction( Action );
        }

        public ActionDialog( BoardInterface board, String title ) : this( board, title, null )
        {
        }

        public ActionDialog( BoardInterface board ) : this( board, "Create Action" )
        {
        }

        private void UpdateUiForAction( BoardAction action )
        {
            if( action is SetLedBoardAction )
            {
                SetLedAction.Checked = true;
                SetLedBoardAction a = action as SetLedBoardAction;
                SetLedActionStateOption.Checked = a.SetToState;
            }
            else if( action is SetPinBoardAction )
            {
                SetPinAction.Checked = true;
                SetPinBoardAction a = action as SetPinBoardAction;
                if( Board.OutputPins.Contains( a.Pin ) )
                {
                    SetPinActionPinOption.SelectedItem = a.Pin;
                }
                SetPinActionStateOption.Checked = a.SetToState;
            }
            else if( action is TogglePinBoardAction )
            {
                TogglePinAction.Checked = true;
                TogglePinBoardAction a = action as TogglePinBoardAction;
                if( Board.OutputPins.Contains( a.Pin ) )
                {
                    TogglePinActionPinOption.SelectedItem = a.Pin;
                }
            }
            else if( action is RunScriptBoardAction )
            {
                RunScriptAction.Checked = true;
                RunScriptBoardAction a = action as RunScriptBoardAction;
                RunScriptActionFileNameOption.Text = a.FileName;
                RunScriptActionArgumentsOption.Text = a.Arguments;
            }
            else
            {
                NoAction.Checked = true;
            }
        }

        private void ShowError( String message )
        {
            MessageBox.Show( this, message, "Failed to Create Action", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private bool CreateActionFromUi( out BoardAction action )
        {
            if( NoAction.Checked )
            {
                action = null;
                return true;
            }
            else if( SetLedAction.Checked )
            {
                bool setToState = SetLedActionStateOption.Checked;
                action = new SetLedBoardAction( setToState );
                return true;
            }
            else if( SetPinAction.Checked )
            {
                if( SetPinActionPinOption.SelectedItem != null )
                {
                    int pin = (int)SetPinActionPinOption.SelectedItem;
                    bool setToState = SetPinActionStateOption.Checked;
                    action = new SetPinBoardAction( pin, setToState );
                    return true;
                }
                else
                {
                    ShowError( "Must select pin." );
                }
            }
            else if( TogglePinAction.Checked )
            {
                if( TogglePinActionPinOption.SelectedItem != null )
                {
                    int pin = (int)TogglePinActionPinOption.SelectedItem;
                    action = new TogglePinBoardAction( pin );
                    return true;
                }
                else
                {
                    ShowError( "Must select pin." );
                }
            }
            else if( RunScriptAction.Checked )
            {
                String fileName = RunScriptActionFileNameOption.Text;
                String arguments = RunScriptActionArgumentsOption.Text;
                if( !String.IsNullOrWhiteSpace( fileName ) )
                {
                    action = new RunScriptBoardAction( fileName, arguments );
                    return true;
                }
            }

            action = null;
            return false;
        }

        private void Ok_Click( object sender, EventArgs e )
        {
            BoardAction a;
            if( CreateActionFromUi( out a ) )
            {
                Action = a;

                DialogResult = DialogResult.OK;
                this.Close();
            }
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

        private void TestAction_Click( object sender, EventArgs e )
        {
            if( Board != null )
            {
                BoardAction action;
                if( CreateActionFromUi( out action ) )
                {
                    if( action != null )
                    {
                        action.Perform( Board );
                    }
                }
            }
        }
    }
}

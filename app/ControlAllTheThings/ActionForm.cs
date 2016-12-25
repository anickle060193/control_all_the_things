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
        public IBoardAction Action { get; set; }

        public ActionForm( IBoardAction currentAction )
        {
            InitializeComponent();

            Action = currentAction;

            DialogResult = DialogResult.Cancel;

            if( Action is SetLedBoardAction )
            {
                SetLedAction.Checked = true;
                SetLedActionStateOption.Checked = ( (SetLedBoardAction)Action ).SetToState;
            }
        }

        public ActionForm() : this( null )
        {
        }

        private void OkButton_Click( object sender, EventArgs e )
        {
            if( SetLedAction.Checked )
            {
                Action = new SetLedBoardAction( SetLedActionStateOption.Checked );
            }

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
    }
}

using ControlAllTheThings.BoardActions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlAllTheThings
{
    public partial class ActionsForm : Form
    {
        public BoardInterface Board { get; private set; }
        public BindingList<BoardAction> BoardActions { get; private set; }

        public ActionsForm( BoardInterface board, String title, List<BoardAction> actions )
        {
            if( board == null )
            {
                throw new ArgumentNullException( "board" );
            }

            InitializeComponent();

            Board = board;
            Text = title;
            BoardActions = new BindingList<BoardAction>();

            if( actions != null )
            {
                foreach( BoardAction a in actions )
                {
                    BoardActions.Add( a );
                }
            }

            ActionsGridView.DataSource = BoardActions;

            DialogResult = DialogResult.OK;
        }

        public ActionsForm( BoardInterface board, String title ) : this( board, title, null )
        {
        }

        public ActionsForm( BoardInterface board ) : this( board, "Actions" )
        {
        }

        private void ActionsGridView_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            if( e.RowIndex >= 0 && ActionsGridView.Columns[ e.ColumnIndex ].Name == ActionsColumnRemove.Name )
            {
                BoardActions.RemoveAt( e.RowIndex );
            }
        }

        private void AddAction_Click( object sender, EventArgs e )
        {
            ActionDialog d = new ActionDialog( Board, "Create Action" );
            if( d.ShowDialog() == DialogResult.OK )
            {
                BoardActions.Add( d.Action );
            }
        }

        private void ActionsGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            if( e.RowIndex >= 0 && ActionsGridView.Columns[ e.ColumnIndex ].Name == ActionsColumnAction.Name )
            {
                BoardAction action = BoardActions[ e.RowIndex ];
                ActionDialog d = new ActionDialog( Board, "Edit Action", action );
                if( d.ShowDialog() == DialogResult.OK )
                {
                    if( d.Action == null )
                    {
                        BoardActions.RemoveAt( e.RowIndex );
                    }
                    else
                    {
                        BoardActions[ e.RowIndex ] = d.Action;
                    }
                }
            }
        }

        private void Ok_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

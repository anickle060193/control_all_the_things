﻿using ControlAllTheThings.BoardActions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlAllTheThings
{
    public partial class ActionsForm : Form
    {
        public BoardInterface Board { get; private set; }
        public List<BoardAction> BoardActions { get; private set; }

        public ActionsForm( BoardInterface board, String title, List<BoardAction> actions )
        {
            if( board == null )
            {
                throw new ArgumentNullException( "board" );
            }

            InitializeComponent();

            Board = board;
            Text = title;
            BoardActions = new List<BoardAction>();

            if( actions != null )
            {
                foreach( BoardAction a in actions )
                {
                    AddNewAction( a );
                }
            }

            DialogResult = DialogResult.OK;
        }

        public ActionsForm( BoardInterface board, String title ) : this( board, title, null )
        {
        }

        public ActionsForm( BoardInterface board ) : this( board, "Actions" )
        {
        }

        private void RemoveActionAt( int index )
        {
            if( index >= 0 )
            {
                BoardActions.RemoveAt( index );
                ActionsGridView.Rows.RemoveAt( index );
            }
        }

        private void AddNewAction( BoardAction action )
        {
            BoardActions.Add( action );
            ActionsGridView.Rows.Add( action, "Remove" );
        }

        private void ActionsGridView_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            if( e.RowIndex >= 0 && e.ColumnIndex == 1 )
            {
                RemoveActionAt( e.RowIndex );
            }
        }

        private void AddAction_Click( object sender, EventArgs e )
        {
            ActionDialog d = new ActionDialog( Board, "Create Action" );
            if( d.ShowDialog() == DialogResult.OK )
            {
                AddNewAction( d.Action );
            }
        }

        private void ActionsGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            if( e.RowIndex >= 0 && e.ColumnIndex == 0 )
            {
                BoardAction action = BoardActions[ e.RowIndex ];
                ActionDialog d = new ActionDialog( Board, "Edit Action", action );
                if( d.ShowDialog() == DialogResult.OK )
                {
                    if( d.Action == null )
                    {
                        RemoveActionAt( e.RowIndex );
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
    }
}

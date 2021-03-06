﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ControlAllTheThings.BoardActions;

namespace ControlAllTheThings.BoardComponents
{
    public partial class ButtonComponent : BaseComponent
    {
        private List<BoardAction> _pressedActions = new List<BoardAction>();
        private List<BoardAction> _unpressedActions = new List<BoardAction>();

        private bool _pressed;
        
        public ButtonComponent()
        {
            InitializeComponent();

            Pressed = false;
        }

        [ReadOnly( true )]
        [Browsable( false )]
        public NamedPin Pin { get; set; }

        [DefaultValue( false )]
        public bool Pressed
        {
            get { return _pressed; }
            set
            {
                _pressed = value;
                this.Invalidate();

                if( _board != null )
                {
                    if( _pressed )
                    {
                        foreach( BoardAction b in _pressedActions )
                        {
                            b.Run( _board );
                        }
                    }
                    else
                    {
                        foreach( BoardAction b in _unpressedActions )
                        {
                            b.Run( _board );
                        }
                    }
                }
            }
        }

        public override void SetBoardInterface( BoardInterface board )
        {
            base.SetBoardInterface( board );

            if( this.Pin != null )
            {
                _board.InputPins.Add( this.Pin );
                _board.PinSet += BoardInterface_PinSet;
            }
        }

        private void BoardInterface_PinSet( object sender, PinSetEventArgs e )
        {
            if( e.Pin == this.Pin )
            {
                this.Pressed = e.State;
            }
        }

        private void ButtonComponent_Paint( object sender, PaintEventArgs e )
        {
            Color backColor = !this.Pressed ? this.BackColor : ControlPaint.Dark( this.BackColor, 0.1f );
            using( SolidBrush b = new SolidBrush( backColor ) )
            {
                e.Graphics.FillRectangle( b, e.ClipRectangle );
            }

            Brush indicatorBrush = this.Pressed ? Brushes.Green : Brushes.Red;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillEllipse( indicatorBrush, 1, 1, 5, 5 );
        }

        private void ButtonComponent_DoubleClick( object sender, EventArgs e )
        {
            if( !ChoosePressedActions() )
            {
                return;
            }
            ChooseUnpressedActions();
        }

        private void ButtonComponent_Load( object sender, EventArgs e )
        {
            CreateQuickAddActionMenus();
        }

        private void CreateQuickAddActionMenus()
        {
            QuickAddPressedActionSetPinMenu.DropDownItems.Clear();
            QuickAddUnpressedActionSetPinMenu.DropDownItems.Clear();
            QuickAddPressedActionTogglePinMenu.DropDownItems.Clear();
            QuickAddUnpressedActionTogglePinMenu.DropDownItems.Clear();

            if( _board == null )
            {
                return;
            }

            foreach( NamedPin pin in _board.OutputPins )
            {
                ToolStripMenuItem pressedSetPinMenu = new ToolStripMenuItem( pin.ToString() );
                QuickAddPressedActionSetPinMenu.DropDownItems.Add( pressedSetPinMenu );

                ToolStripItem pressedSetPinOnItem = pressedSetPinMenu.DropDownItems.Add( "On" );
                pressedSetPinOnItem.Tag = new Tuple<NamedPin, bool>( pin, true );
                pressedSetPinOnItem.Click += QuickAddPressedSetPin_Click;

                ToolStripItem pressedSetPinOffItem = pressedSetPinMenu.DropDownItems.Add( "Off" );
                pressedSetPinOffItem.Tag = new Tuple<NamedPin, bool>( pin, false );
                pressedSetPinOffItem.Click += QuickAddPressedSetPin_Click;

                ToolStripMenuItem unpressedSetPinMenu = new ToolStripMenuItem( pin.ToString() );
                QuickAddUnpressedActionSetPinMenu.DropDownItems.Add( unpressedSetPinMenu );

                ToolStripItem unpressedSetPinOnItem = unpressedSetPinMenu.DropDownItems.Add( "On" );
                unpressedSetPinOnItem.Tag = new Tuple<NamedPin, bool>( pin, true );
                unpressedSetPinOnItem.Click += QuickAddPressedSetPin_Click;

                ToolStripItem unpressedSetPinOffItem = unpressedSetPinMenu.DropDownItems.Add( "Off" );
                unpressedSetPinOffItem.Tag = new Tuple<NamedPin, bool>( pin, false );
                unpressedSetPinOffItem.Click += QuickAddUnpressedSetPin_Click;

                ToolStripItem pressedTogglePinItem = QuickAddPressedActionTogglePinMenu.DropDownItems.Add( pin.ToString() );
                pressedTogglePinItem.Tag = pin;
                pressedTogglePinItem.Click += QuickAddPressedTogglePin_Click;

                ToolStripItem unpressedTogglePinItem = QuickAddUnpressedActionTogglePinMenu.DropDownItems.Add( pin.ToString() );
                unpressedTogglePinItem.Tag = pin;
                unpressedTogglePinItem.Click += QuickAddUnpressedTogglePin_Click;
            }
        }

        private void QuickAddPressedActionSetLed_Click( object sender, EventArgs e )
        {
            bool setToState = sender == QuickAddPressedActionSetLedOn;
            _pressedActions.Add( new SetLedBoardAction( setToState ) );
        }

        private void QuickAddUnpressedActionSetLed_Click( object sender, EventArgs e )
        {
            bool setToState = sender == QuickAddUnpressedActionSetLedOn;
            _unpressedActions.Add( new SetLedBoardAction( setToState ) );
        }

        private void QuickAddPressedSetPin_Click( object sender, EventArgs e )
        {
            ToolStripItem item = sender as ToolStripItem;
            Tuple<NamedPin, bool> tag = (Tuple<NamedPin, bool>)item.Tag;
            _pressedActions.Add( new SetPinBoardAction( tag.Item1, tag.Item2 ) );
        }

        private void QuickAddUnpressedSetPin_Click (object sender, EventArgs e )
        {
            ToolStripItem item = sender as ToolStripItem;
            Tuple<NamedPin, bool> tag = (Tuple<NamedPin, bool>)item.Tag;
            _unpressedActions.Add( new SetPinBoardAction( tag.Item1, tag.Item2 ) );
        }

        private void QuickAddPressedTogglePin_Click( object sender, EventArgs e )
        {
            ToolStripItem item = sender as ToolStripItem;
            NamedPin pin = (NamedPin)item.Tag;
            _pressedActions.Add( new TogglePinBoardAction( pin ) );
        }

        private void QuickAddUnpressedTogglePin_Click( object sender, EventArgs e )
        {
            ToolStripItem item = sender as ToolStripItem;
            NamedPin pin = (NamedPin)item.Tag;
            _unpressedActions.Add( new TogglePinBoardAction( pin ) );
        }

        private void QuickAddPressedCustomActionMenuItem_Click( object sender, EventArgs e )
        {
            ActionDialog d = new ActionDialog( _board, "Add Pressed Action" );
            if( d.ShowDialog() == DialogResult.OK )
            {
                _pressedActions.Add( d.Action );
            }
        }

        private void QuickAddUnpressedCustomActionMenuItem_Click( object sender, EventArgs e )
        {
            ActionDialog d = new ActionDialog( _board, "Add Unpressed Action" );
            if( d.ShowDialog() == DialogResult.OK )
            {
                _unpressedActions.Add( d.Action );
            }
        }

        private bool ChoosePressedActions()
        {
            ActionsForm a = new ActionsForm( _board, this.Name + " Pressed Actions", _pressedActions );
            if( a.ShowDialog() == DialogResult.OK )
            {
                _pressedActions.Clear();
                _pressedActions.AddRange( a.BoardActions );
                return true;
            }
            return false;
        }

        private bool ChooseUnpressedActions()
        {
            ActionsForm a = new ActionsForm( _board, this.Name + " Unpressed Actions", _unpressedActions );
            if( a.ShowDialog() == DialogResult.OK )
            {
                _unpressedActions.Clear();
                _unpressedActions.AddRange( a.BoardActions );
                return true;
            }
            return false;
        }

        private void SetPressedActions_Click( object sender, EventArgs e )
        {
            ChoosePressedActions();
        }

        private void SetUnpressedActions_Click( object sender, EventArgs e )
        {
            ChooseUnpressedActions();
        }

        private void ButtonComponentContextMenu_Opening( object sender, CancelEventArgs e )
        {
            ClearPressedActions.Enabled = _pressedActions.Count > 0;
            ClearUnpressedActions.Enabled = _unpressedActions.Count > 0;
        }

        private void ClearPressedActions_Click( object sender, EventArgs e )
        {
            _pressedActions.Clear();
        }

        private void ClearUnpressedActions_Click( object sender, EventArgs e )
        {
            _unpressedActions.Clear();
        }

        class ButtonComponentSettings : ISetting
        {
            public List<BoardAction> PressedActionSetting = new List<BoardAction>();
            public List<BoardAction> UnpressedActionSetting = new List<BoardAction>();
        }

        public override void SaveSettings( Settings settings )
        {
            settings[ this.Name ] = new ButtonComponentSettings()
            {
                PressedActionSetting = _pressedActions,
                UnpressedActionSetting = _unpressedActions
            };
        }

        public override void LoadSettings( Settings settings )
        {
            if( settings.ContainsKey( this.Name ) )
            {
                ButtonComponentSettings s = (ButtonComponentSettings)settings[ this.Name ];
                _pressedActions.AddRange( s.PressedActionSetting.FindAll( a => a.Valid( _board ) ) );
                _unpressedActions.AddRange( s.UnpressedActionSetting.FindAll( a => a.Valid( _board ) ) );
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ControlAllTheThings.BoardActions;

namespace ControlAllTheThings
{
    public partial class ButtonComponent : UserControl
    {
        private Color _pressedColor;
        private Color _unpressedColor;

        private BoardAction _pressedAction;
        private BoardAction _unpressedAction;

        private bool _pressed;
        private int _pin;
        
        public ButtonComponent()
        {
            InitializeComponent();

            UnpressedColor = Color.LightGray;
            PressedColor = Color.DarkGray;

            Pressed = false;
            Pin = -1;
        }

        public BoardInterface BoardInterface { get; set; }

        [Browsable( false )]
        public BoardAction PressedAction
        {
            get { return _pressedAction; }
            set
            {
                _pressedAction = value;
                ClearPressedAction.Enabled = _pressedAction != null;
            }
        }

        [Browsable( false )]
        public BoardAction UnpressedAction
        {
            get { return _unpressedAction; }
            set
            {
                _unpressedAction = value;
                ClearUnpressedAction.Enabled = _unpressedAction != null;
            }
        }

        [DefaultValue( typeof( Color ), "LightGray" )]
        public Color UnpressedColor
        {
            get { return _unpressedColor; }
            set
            {
                _unpressedColor = value;
                if( !this.Pressed )
                {
                    this.BackColor = _unpressedColor;
                }
            }
        }

        [DefaultValue( typeof( Color ), "DarkGray" )]
        public Color PressedColor
        {
            get { return _pressedColor; }
            set
            {
                _pressedColor = value;
                if( this.Pressed )
                {
                    this.BackColor = _pressedColor;
                }
            }
        }

        [DefaultValue( -1 )]
        public int Pin
        {
            get { return _pin; }
            set
            {
                _pin = value;
                this.Invalidate();
            }
        }

        [DefaultValue( false )]
        public bool Pressed
        {
            get { return _pressed; }
            set
            {
                _pressed = value;
                if( _pressed )
                {
                    this.BackColor = this.PressedColor;
                }
                else
                {
                    this.BackColor = this.UnpressedColor;
                }
                this.Invalidate();

                if( BoardInterface != null )
                {
                    if( _pressed )
                    {
                        if( PressedAction != null )
                        {
                            PressedAction.Perform( BoardInterface );
                        }
                    }
                    else
                    {
                        if( UnpressedAction != null )
                        {
                            UnpressedAction.Perform( BoardInterface );
                        }
                    }
                }
            }
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint( e );

            Brush b = this.Pressed ? Brushes.Green: Brushes.Red;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillEllipse( b, 1, 1, 5, 5 );

            if( this.Pin >= 0 )
            {
                String pinString = this.Pin.ToString();
                float pinStringWidth = e.Graphics.MeasureString( pinString, Font ).Width;
                e.Graphics.DrawString( pinString, Font, Brushes.Black, this.Width - pinStringWidth - 1, 0.0f );
            }
        }

        private bool ChoosePressedAction()
        {
            ActionForm f = new ActionForm( PressedAction );
            if( f.ShowDialog() == DialogResult.OK )
            {
                PressedAction = f.Action;
                return true;
            }
            return false;
        }

        private bool ChooseUnpressedAction()
        {
            ActionForm f = new ActionForm( UnpressedAction );
            if( f.ShowDialog() == DialogResult.OK )
            {
                UnpressedAction = f.Action;
                return true;
            }
            return false;
        }

        private void SetPressedAction_Click( object sender, EventArgs e )
        {
            ChoosePressedAction();
        }

        private void SetUnpressedAction_Click( object sender, EventArgs e )
        {
            ChooseUnpressedAction();
        }

        private void ClearPressedAction_Click( object sender, EventArgs e )
        {
            PressedAction = null;
        }

        private void ClearUnpressedAction_Click( object sender, EventArgs e )
        {
            UnpressedAction = null;
        }

        private void ButtonComponent_DoubleClick( object sender, EventArgs e )
        {
            if( !ChoosePressedAction() )
            {
                return;
            }
            ChooseUnpressedAction();
        }
    }
}

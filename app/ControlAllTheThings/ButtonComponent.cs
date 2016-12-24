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

namespace ControlAllTheThings
{
    public partial class ButtonComponent : UserControl
    {
        private Color _pressedColor;
        private Color _unpressedColor;

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
    }
}

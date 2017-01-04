using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ControlAllTheThings.BoardComponents
{
    public partial class LedButtonComponent : ButtonComponent
    {
        private int _ledPin;
        private Color _ledColor;
        private bool _ledOn;

        [DefaultValue( -1 )]
        public int LedPin
        {
            get { return _ledPin; }
            set
            {
                _ledPin = value;

                this.Invalidate();
            }
        }

        [DefaultValue( typeof( Color ), "Blue" )]
        public Color LedColor
        {
            get { return _ledColor; }
            set
            {
                _ledColor = value;

                this.Invalidate();
            }
        }

        [DefaultValue( false )]
        public bool LedOn
        {
            get { return _ledOn; }
            set
            {
                _ledOn = value;

                this.Invalidate();
            }
        }

        public LedButtonComponent()
        {
            InitializeComponent();

            LedPin = -1;
            LedColor = Color.Blue;
            LedOn = false;
        }

        private void LedButtonComponent_Paint( object sender, PaintEventArgs e )
        {
            Rectangle bounds = this.ClientRectangle;
            int x = bounds.X + 5;
            int y = bounds.Y + 5;
            int width = bounds.Right - bounds.Left - 10 - 1;
            int height = bounds.Bottom - bounds.Top - 10 - 1;

            Color ledColor;
            if( LedOn )
            {
                ledColor = this.LedColor;
            }
            else
            {
                ledColor = ControlPaint.Dark( this.LedColor );
            }

            using( SolidBrush b = new SolidBrush( ledColor ) )
            {
                e.Graphics.FillEllipse( b, x, y, width, height );
            }

            if( this.LedPin >= 0 )
            {
                String pinString = this.LedPin.ToString();
                SizeF size = e.Graphics.MeasureString( pinString, Font );
                float pinStringX = this.Width - size.Width - 1;
                float pinStringY = this.Height - size.Height - 1;
                e.Graphics.DrawString( pinString, Font, Brushes.Black, pinStringX, pinStringY );
            }
        }

        public override void SetBoardInterface( BoardInterface board )
        {
            base.SetBoardInterface( board );

            if( this.LedPin >= 0 )
            {
                _board.OutputPins.Add( this.LedPin );
            }
        }
    }
}

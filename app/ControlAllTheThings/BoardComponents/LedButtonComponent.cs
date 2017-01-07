using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ControlAllTheThings.BoardComponents
{
    public partial class LedButtonComponent : ButtonComponent
    {
        private Color _ledColor;
        private bool _ledOn;

        [ReadOnly( true )]
        [Browsable( false )]
        public NamedPin LedPin { get; set; }

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
        }

        public override void SetBoardInterface( BoardInterface board )
        {
            base.SetBoardInterface( board );

            if( this.LedPin != null )
            {
                _board.OutputPins.Add( this.LedPin );
                _board.PinSet += BoardInterface_PinSet;
            }
        }

        private void BoardInterface_PinSet( object sender, PinSetEventArgs e )
        {
            if( e.Pin == this.LedPin )
            {
                this.LedOn = e.State;
            }
        }
    }
}

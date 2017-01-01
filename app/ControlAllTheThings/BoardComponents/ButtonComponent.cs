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

namespace ControlAllTheThings.BoardComponents
{
    public partial class ButtonComponent : Component
    {
        private Color _pressedColor;
        private Color _unpressedColor;

        private List<BoardAction> _pressedActions = new List<BoardAction>();
        private List<BoardAction> _unpressedActions = new List<BoardAction>();

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
                        foreach( BoardAction b in _pressedActions )
                        {
                            b.Perform( BoardInterface );
                        }
                    }
                    else
                    {
                        foreach( BoardAction b in _unpressedActions )
                        {
                            b.Perform( BoardInterface );
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

        private bool ChoosePressedActions()
        {
            ActionsForm a = new ActionsForm( BoardInterface, this.Name + " Pressed Actions", _pressedActions );
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
            ActionsForm a = new ActionsForm( BoardInterface, this.Name + " Unpressed Actions", _unpressedActions );
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

        private void ClearPressedActions_Click( object sender, EventArgs e )
        {
            _pressedActions.Clear();
        }

        private void ClearUnpressedActions_Click( object sender, EventArgs e )
        {
            _unpressedActions.Clear();
        }

        private void ButtonComponent_DoubleClick( object sender, EventArgs e )
        {
            if( !ChoosePressedActions() )
            {
                return;
            }
            ChooseUnpressedActions();
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
                _pressedActions.AddRange( s.PressedActionSetting.FindAll( a => a.Valid( BoardInterface ) ) );
                _unpressedActions.AddRange( s.UnpressedActionSetting.FindAll( a => a.Valid( BoardInterface ) ) );
            }
        }
    }
}

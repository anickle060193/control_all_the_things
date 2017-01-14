using ControlAllTheThings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace PrototypeController
{
    public partial class PrototypeBoardControl : VirtualBoardControl
    {
        public PrototypeBoardControl()
        {
            InitializeComponent();

            WhiteLatch.Pin = NamedPin.CreateNamedPin( 15, "White Latch" );
            WhiteLatch.LedPin = NamedPin.CreateNamedPin( 14, "White Latch LED" );

            BlueLatch.Pin = NamedPin.CreateNamedPin( 17, "Blue Latch" );
            BlueLatch.LedPin = NamedPin.CreateNamedPin( 16, "Blue Latch LED" );

            GreenLatch.Pin = NamedPin.CreateNamedPin( 20, "Green Latch" );
            GreenLatch.LedPin = NamedPin.CreateNamedPin( 19, "Green Latch LED" );

            YellowLatch.Pin = NamedPin.CreateNamedPin( 23, "Yellow Latch" );
            YellowLatch.LedPin = NamedPin.CreateNamedPin( 22, "Yellow Latch LED" );

            WhiteButton.Pin = NamedPin.CreateNamedPin( 11, "White Button" );
            WhiteButton.LedPin = NamedPin.CreateNamedPin( 9, "White Button LED" );

            BlueButton.Pin = NamedPin.CreateNamedPin( 7, "Blue Button" );
            BlueButton.LedPin = NamedPin.CreateNamedPin( 6, "Blue Button LED" );

            GreenButton.Pin = NamedPin.CreateNamedPin( 4, "Green Button" );
            GreenButton.LedPin = NamedPin.CreateNamedPin( 3, "Green Button LED" );

            YellowButton.Pin = NamedPin.CreateNamedPin( 0, "Yellow Button" );
            YellowButton.LedPin = NamedPin.CreateNamedPin( 1, "Yellow Button LED" );
        }

        public override void SetBoardInterface( BoardInterface board )
        {
            base.SetBoardInterface( board );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings.BoardActions
{
    class TogglePinBoardAction : BoardAction
    {
        public int Pin { get; private set; }

        public TogglePinBoardAction( int pin )
        {
            Pin = pin;
        }

        public override void Perform( BoardInterface b )
        {
            if( !b.Initializing )
            {
                b.TogglePin( Pin );
            }
        }
    }
}

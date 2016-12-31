using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings.BoardActions
{
    class SetPinBoardAction : BoardAction
    {
        public int Pin { get; private set; }
        public bool SetToState { get; private set; }

        public SetPinBoardAction( int pin, bool setToState )
        {
            Pin = pin;
            SetToState = setToState;
        }

        public override void Perform( BoardInterface b )
        {
            b.SetPin( Pin, SetToState );
        }

        public override bool Valid( BoardInterface b )
        {
            return b.OutputPins.Contains( Pin );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings.BoardActions
{
    class SetLedBoardAction : BoardAction
    {
        public bool SetToState { get; private set; }

        public SetLedBoardAction( bool setToState )
        {
            SetToState = setToState;
        }

        public override void Perform( BoardInterface b )
        {
            b.SetLed( SetToState );
        }

        public override bool Valid( BoardInterface b )
        {
            return true;
        }
    }
}

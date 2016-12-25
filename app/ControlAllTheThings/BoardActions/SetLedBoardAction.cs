using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings.BoardActions
{
    class SetLedBoardAction : IBoardAction
    {
        public bool SetToState { get; private set; }

        public SetLedBoardAction( bool setToState )
        {
            SetToState = setToState;
        }

        public void Perform( BoardInterface b )
        {
            b.SetLed( SetToState );
        }

        public String BoardAction
        {
            get { return "Set LED"; }
        }
    }
}

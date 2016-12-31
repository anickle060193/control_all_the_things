using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings.BoardActions
{
    public abstract class BoardAction
    {
        public abstract void Perform( BoardInterface b );
        public abstract bool Valid( BoardInterface b );
    }
}

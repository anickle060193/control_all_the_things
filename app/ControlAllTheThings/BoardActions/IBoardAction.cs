using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings.BoardActions
{
    public interface IBoardAction
    {
        String BoardAction { get; }
        void Perform( BoardInterface b );
    }
}

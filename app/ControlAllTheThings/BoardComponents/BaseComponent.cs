using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAllTheThings.BoardComponents
{
    public abstract class BaseComponent : UserControl
    {
        protected BoardInterface _board;

        public virtual void SetBoardInterface( BoardInterface board )
        {
            _board = board;
        }

        public abstract void SaveSettings( Settings settings );
        public abstract void LoadSettings( Settings settings );
    }
}

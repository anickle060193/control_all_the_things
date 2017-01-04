using System;
using System.Windows.Forms;

namespace ControlAllTheThings.BoardComponents
{
    public class BaseComponent : UserControl
    {
        protected BoardInterface _board;

        public virtual void SetBoardInterface( BoardInterface board )
        {
            _board = board;
        }

        public virtual void SaveSettings( Settings settings )
        {
            throw new NotImplementedException();
        }

        public virtual void LoadSettings( Settings settings )
        {
            throw new NotImplementedException();
        }
    }
}

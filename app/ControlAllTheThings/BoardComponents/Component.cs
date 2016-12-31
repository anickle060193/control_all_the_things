using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAllTheThings.BoardComponents
{
    public abstract class Component : UserControl
    {
        public abstract void SaveSettings( Settings settings );
        public abstract void LoadSettings( Settings settings );
    }
}

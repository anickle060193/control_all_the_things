using ControlAllTheThings;

namespace PrototypeController
{
    public partial class PrototypeControllerForm : BaseControllerForm<PrototypeBoardControl>
    {
        public PrototypeControllerForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.PrototypeControllerIcon;
        }
    }
}

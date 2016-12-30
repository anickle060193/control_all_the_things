using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings
{
    public class Settings : Dictionary<String, ButtonSettings>
    {
        public ButtonSettings AddButtonSettings( String buttonName )
        {
            ButtonSettings s = new ButtonSettings();
            this[ buttonName ] = s;
            return s;
        }
    }

    public class ButtonSettings
    {
        public Setting PressedActionSetting { get; set; }
        public Setting UnpressedActionSetting { get; set; }

        public ButtonSettings SetPressedAction( Setting pressedActionSetting )
        {
            PressedActionSetting = pressedActionSetting;
            return this;
        }

        public ButtonSettings SetUnpressedAction( Setting unpressedActionSetting )
        {
            UnpressedActionSetting = unpressedActionSetting;
            return this;
        }
    }

    public class Setting : Dictionary<String, Object> { }
}

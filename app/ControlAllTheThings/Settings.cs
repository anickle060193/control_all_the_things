using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void Save( String settingsFileName )
        {
            try
            {
                String s = JsonConvert.SerializeObject( this, Formatting.Indented );

                using( StreamWriter w = new StreamWriter( settingsFileName ) )
                {
                    w.Write( s );
                }
            }
            catch( IOException ) { }
            catch( JsonException ) { }
        }

        public static Settings Load( String settingsFileName )
        {
            try
            {
                String s = null;
                using( StreamReader r = new StreamReader( settingsFileName ) )
                {
                    s = r.ReadToEnd();
                }
                return JsonConvert.DeserializeObject<Settings>( s );
            }
            catch( IOException ) { }
            catch( JsonException ) { }

            return null;
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

    public class Setting : Dictionary<String, Object>
    {
        public T Get<T>( String key )
        {
            return (T)Convert.ChangeType( this[ key ], typeof( T ) );
        }
    }
}

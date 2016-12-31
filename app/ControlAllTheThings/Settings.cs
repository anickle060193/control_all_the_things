using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings
{
    public interface ISetting
    {
    }

    public class Settings : Dictionary<String, ISetting>
    {
        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.Auto
        };

        public void Save( String settingsFileName )
        {
            try
            {
                String s = JsonConvert.SerializeObject( this, _serializerSettings );

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
                return JsonConvert.DeserializeObject<Settings>( s, _serializerSettings );
            }
            catch( IOException ) { }
            catch( JsonException ) { }

            return null;
        }
    }
}

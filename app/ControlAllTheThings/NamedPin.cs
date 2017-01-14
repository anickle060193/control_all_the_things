using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace ControlAllTheThings
{
    public class NamedPin
    {
        private static readonly Dictionary<int, NamedPin> _namedPinsByPin = new Dictionary<int, NamedPin>();
        private static readonly Dictionary<String, NamedPin> _namedPinsByName = new Dictionary<String, NamedPin>();

        public int Pin { get; private set; }
        public String Name { get; private set; }

        private NamedPin( int pin, String name )
        {
            Pin = pin;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public static NamedPin CreateNamedPin( int pin, String name )
        {
            if( _namedPinsByPin.ContainsKey( pin ) )
            {
                NamedPin p = _namedPinsByPin[ pin ];
                if( p.Name != name )
                {
                    throw new ArgumentException( String.Format( "Named pin already exists: {0} - {1}", pin, _namedPinsByPin[ pin ] ) );
                }
                return p;
            }
            else
            {
                NamedPin p = new NamedPin( pin, name );
                _namedPinsByPin.Add( pin, p );
                _namedPinsByName.Add( name, p );
                return p;
            }
        }

        public static NamedPin GetNamedPin( int pin )
        {
            if( !_namedPinsByPin.ContainsKey( pin ) )
            {
                throw new ArgumentException( "NamedPin has not been created: " + pin.ToString() );
            }

            return _namedPinsByPin[ pin ];
        }

        public static NamedPin GetNamedPin( String name )
        {
            if( !_namedPinsByName.ContainsKey( name ) )
            {
                throw new ArgumentException( "NamedPin has not been created: " + name );
            }

            return _namedPinsByName[ name ];
        }

        public class NamedPinJsonConverter : JsonConverter
        {
            public override bool CanConvert( Type objectType )
            {
                return objectType == typeof( NamedPin );
            }

            public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer )
            {
                return NamedPin.GetNamedPin( JToken.Load( reader ).Value<String>() );
            }

            public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer )
            {
                writer.WriteValue( ( (NamedPin)value ).Name );
            }
        }
    }
}

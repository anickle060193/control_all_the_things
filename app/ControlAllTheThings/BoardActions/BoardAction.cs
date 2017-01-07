using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ControlAllTheThings.BoardActions
{
    public abstract class BoardAction
    {
        [JsonIgnore]
        public String Name
        {
            get { return this.ToString(); }
        }

        public abstract void Perform( BoardInterface b );
        public abstract bool Valid( BoardInterface b );

        private String FormatPropertyValue( Object value )
        {
            if( value is String )
            {
                return "\"" + (String)value + "\"";
            }
            else
            {
                return value.ToString();
            }
        }

        public override string ToString()
        {
            Type t = this.GetType();
            
            List<String> propertyStrings = new List<String>();
            foreach( PropertyInfo p in t.GetProperties() )
            {
                if( p.Name != "Name" )
                {
                    propertyStrings.Add( String.Format( "{0}={1}", p.Name, FormatPropertyValue( p.GetValue( this ) ) ) );
                }
            }

            return String.Format( "{0}( {1} )", t.Name, String.Join( ", ", propertyStrings ) );

        }
    }
}

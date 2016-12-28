using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings
{
    public class Logger : IDisposable
    {
        private readonly StreamWriter _writer;

        public String FileName { get; private set; }

        public Logger() : this( Path.Combine( Path.GetTempPath(), "control_all_the_things.log" ) )
        {
        }

        public Logger( String logFileName )
        {
            FileName = logFileName;
            try
            {
                _writer = new StreamWriter( FileName );
                _writer.AutoFlush = true;
            }
            catch( IOException )
            {
            }
        }

        public void Log( String format, params Object[] args )
        {
            String message = String.Format( format, args );
            try
            {
                _writer.WriteLine( "[{0:MM/dd/yy hh:mm:ss.ff tt}] {1}", DateTime.Now, message );
            }
            catch( IOException )
            {
            }
        }

        public void Dispose()
        {
            try
            {
                _writer.Close();
            }
            catch( IOException )
            {
            }
        }
    }
}

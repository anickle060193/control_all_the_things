﻿using System;
using System.IO;

namespace ControlAllTheThings
{
    public static class Logger
    {
        private static StreamWriter _writer;
        private static String _fileName;

        public static void Init( String logFileName )
        {
            Close();

            _fileName = logFileName;
            try
            {
                _writer = new StreamWriter( _fileName );
                _writer.AutoFlush = true;
            }
            catch( IOException )
            {
            }
        }

        public static void Init()
        {
            Init( Path.Combine( Path.GetTempPath(), "control_all_the_things.log" ) );
        }

        public static void Log( String format, params Object[] args )
        {
            if( _writer != null )
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
        }

        public static String GetFileName()
        {
            return _fileName;
        }

        public static void Close()
        {
            if( _writer != null )
            {
                _writer.Close();
                _writer = null;
                _fileName = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ControlAllTheThings
{
    class MessageReceivedEventArgs
    {
        public String Message { get; private set; }

        public MessageReceivedEventArgs( String message )
        {
            Message = message;
        }
    }

    class Server
    {
        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        private readonly TcpListener _listener;
        private readonly List<TcpClient> _clients = new List<TcpClient>();

        private Thread _listenThread;

        public Server()
        {
            _listener = new TcpListener( System.Net.IPAddress.Parse( "127.0.0.1" ), 3654 );
        }

        public void Start()
        {
            if( _listenThread != null )
            {
                this.Stop();
            }

            _listenThread = new Thread( ListenForClients )
            {
                IsBackground = true
            };
            _listenThread.Start();
        }

        public void Stop()
        {
            _listener.Stop();
            if( _listenThread != null )
            {
                _listenThread.Abort();
                _listenThread = null;
            }
            foreach( TcpClient c in _clients )
            {
                c.Close();
            }
            _clients.Clear();
        }

        private void ListenForClients()
        {
            _listener.Start();

            try
            {
                while( true )
                {
                    TcpClient client = _listener.AcceptTcpClient();
                    _clients.Add( client );
                    Thread clientThread = new Thread( HandleClientCommunication )
                    {
                        IsBackground = true
                    };
                    clientThread.Start( client );
                }
            }
            catch( SocketException ) { }
            finally
            {
                this.Stop();
            }
        }

        private void HandleClientCommunication( Object parameter )
        {
            TcpClient client = (TcpClient)parameter;

            try
            {
                NetworkStream clientStream = client.GetStream();

                byte[] buffer = new byte[ 4096 ];
                int bytesRead = 0;
                while( ( bytesRead = clientStream.Read( buffer, 0, buffer.Length ) ) != 0 )
                {
                    String message = Encoding.ASCII.GetString( buffer, 0, bytesRead );
                    MessageReceived?.Invoke( this, new MessageReceivedEventArgs( message ) );
                }
            }
            catch { }
            finally
            {
                client.Close();
                _clients.Remove( client );
            }
        }
    }
}

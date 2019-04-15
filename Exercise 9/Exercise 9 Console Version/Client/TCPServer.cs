using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class TCPServer
    {
        public static string DefaultIPAddress = "127.0.0.1";
        public const int DefaultPort = 1200;
        public const int ListenerCount = 1;

        private IMessageProcessor processor;
        private Socket socket;
        private string message;


        public TCPServer(IMessageProcessor processor, string ipAddress, int port)
        {
            this.processor = processor;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            processor?.Process($"TCP Server listening on {endPoint.ToString()}");
            socket.Bind(endPoint);
            socket.Listen(ListenerCount);
        }

        public void Listen()
        {
            Socket acceptedAccept = socket.Accept();

            do
            {
                byte[] acceptedData = new byte[acceptedAccept.SendBufferSize];

                int bufferedCount = acceptedAccept.Receive(acceptedData);

                byte[] data = new byte[bufferedCount];

                for (int i = 0; i < bufferedCount; i++)
                {
                    data[i] = acceptedData[i];
                }

                message = Encoding.Default.GetString(data);
                processor?.Process(message);
            } while (!message.ToUpper().Equals("Konec".ToUpper()));
        }
    }
}

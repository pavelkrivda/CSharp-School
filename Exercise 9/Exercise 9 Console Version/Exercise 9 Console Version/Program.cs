using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1200);
            try
            {
                socket.Connect(remoteEP);
                Console.WriteLine($"TCP Client liste with TCP Server {remoteEP.ToString()}");

                while (true)
                {
                    Console.Write("> ");
                    string message = Console.ReadLine();
                    byte[] data = Encoding.Default.GetBytes(message);
                    socket.Send(data);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"TCP Client cannot be connected to {remoteEP.ToString()}. {e.Message}");
            }
        }
    }
}

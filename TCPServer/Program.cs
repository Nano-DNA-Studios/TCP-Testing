using System.Numerics;

namespace TCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(8888);

            server.StartServer();

            string data = (string)server.DataReceived;


            Console.WriteLine(data);

        }       
    }
}

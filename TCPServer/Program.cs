using System.Numerics;
using System.Text.Json;

namespace TCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(8888);

            server.StartServer();

            //MessageContent data = server.GetData<MessageContent>();
            byte[] data = server.GetData<byte[]>();

            File.WriteAllBytes("data.out", data);

            Console.WriteLine(data);

        }       
    }
}

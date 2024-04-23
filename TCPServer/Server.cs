using System.Net.Sockets;
using System.Net;
using System.Text.Json;

namespace TCPServer
{
    internal class Server
    {
        private TcpListener listener;

        public object DataReceived { get; private set; }

        public bool DataHasBeenReceived { get; private set;}

        public Server(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
        }

        public void StartServer()
        {
            DataHasBeenReceived = false;
            try
            {
                Console.WriteLine("Server is running...");
                while (!DataHasBeenReceived)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Connected to client.");
                    HandleClient(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                listener.Stop();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            MemoryStream memoryStream = new MemoryStream();

            byte[] buffer = new byte[256];
            int bytesRead;

            try
            {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, bytesRead);
                }

                memoryStream.Position = 0;
                DataReceived = JsonSerializer.Deserialize<string>(memoryStream);
                Console.WriteLine("Received All Data");
                DataHasBeenReceived = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                stream.Close();
                client.Close();
            }
        }
    }
}

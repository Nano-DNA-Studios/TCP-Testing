using System.Net.Sockets;
using System.Text.Json;

namespace TCPClient
{
    internal class Client
    {
        public void SendData<T>(string server, int port, T data)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            MemoryStream memoryStream = new MemoryStream();

            try
            {
                JsonSerializer.Serialize(memoryStream, data, new JsonSerializerOptions { WriteIndented = true });
                byte[] buffer = memoryStream.ToArray();
                int bytesSent = 0;

                while (bytesSent < buffer.Length)
                {
                    int bytesToSend = Math.Min(256, buffer.Length - bytesSent);
                    stream.Write(buffer, bytesSent, bytesToSend);
                    bytesSent += bytesToSend;
                }

                Console.WriteLine("Sent data: " + data.ToString());
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

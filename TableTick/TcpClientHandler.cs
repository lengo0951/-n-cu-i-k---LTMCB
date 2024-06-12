using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TableTick
{
    public class TcpClientHandler
    {
        private TcpClient client;
        private NetworkStream stream;

        public TcpClientHandler(string serverIp, int serverPort)
        {
            client = new TcpClient(serverIp, serverPort);
            stream = client.GetStream();
        }

        public async Task SendMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);
        }

        public async Task ReceiveMessages(Action<string> onMessageReceived)
        {
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                onMessageReceived(message);
            }
        }

        public void Close()
        {
            stream.Close();
            client.Close();
        }
    }
}

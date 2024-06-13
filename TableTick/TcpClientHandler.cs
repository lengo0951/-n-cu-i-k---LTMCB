using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TableTick
{
    public class TcpClientHandler
    {
        private readonly string serverIp;
        private readonly int port;
        private TcpClient client;
        private NetworkStream stream;

        public TcpClientHandler(string serverIp, int port)
        {
            this.serverIp = serverIp;
            this.port = port;
            client = new TcpClient();
        }

        public async Task Connect()
        {
            await client.ConnectAsync(serverIp, port);
            stream = client.GetStream();
        }

        public async Task SendMessage(string message)
        {
            if (client.Connected)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);
            }
        }

        public async Task ReceiveMessages(Action<string> onMessageReceived)
        {
            byte[] buffer = new byte[1024];
            while (client.Connected)
            {
                int byteCount = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (byteCount > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    onMessageReceived(message);
                }
            }
        }

        public void Disconnect()
        {
            stream.Close();
            client.Close();
        }
    }
}

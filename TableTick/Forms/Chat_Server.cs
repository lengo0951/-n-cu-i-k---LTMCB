using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTick.Forms
{
    public partial class Chat_Server : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();

        public Chat_Server()
        {
            InitializeComponent();
            btn_listen.Click += Btn_listen_Click;
        }

        private async void Btn_listen_Click(object sender, EventArgs e)
        {
            try
            {
                int port = 9000;
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(ip, port);
                server.Start();
                MessageBox.Show("Server started. Listening for connections...");

                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    Task.Run(() => HandleClientAsync(client));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();

                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Hiển thị tin nhắn từ client trên message_box_server
                    Invoke((Action)(() =>
                    {
                        message_box_server.AppendText("Client: " + receivedMessage + Environment.NewLine);
                        message_box_server.ScrollToCaret();
                    }));

                    // Gửi tin nhắn từ một client đến tất cả các client khác
                    BroadcastMessage(receivedMessage, client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client disconnected: " + ex.Message);
            }
            finally
            {
                client.Close();
                clients.Remove(client);
            }
        }

        private void BroadcastMessage(string message, TcpClient sender)
        {
            foreach (TcpClient receiver in clients)
            {
                if (receiver != sender)
                {
                    NetworkStream stream = receiver.GetStream();
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            server?.Stop();

            foreach (TcpClient client in clients)
            {
                client.Close();
            }
        }
    }
}

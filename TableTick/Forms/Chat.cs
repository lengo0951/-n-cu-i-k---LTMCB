using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTick.Forms
{
    public partial class Chat : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private readonly string serverIp = "127.0.0.1";
        private readonly int serverPort = 8888;
        private bool connected = false;

        public Chat()
        {
            InitializeComponent();
        }

        private async void ConnectToServer()
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(serverIp, serverPort);
                stream = client.GetStream();
                connected = true;
                MessageBox.Show("Connected to the server!");
                Task.Run(() => ReceiveMessage());
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Failed to connect to the server: " + ex.Message);
            }
        }

        private async Task ReceiveMessage()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (connected)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    DisplayMessage(receivedMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving message: " + ex.Message);
            }
        }

        private void DisplayMessage(string message)
        {
            if (mesage_box.InvokeRequired)
            {
                var invoker = new Action<string>(DisplayMessage);
                mesage_box.Invoke(invoker, message);
            }
            else
            {
                if (message.Contains('\n'))
                {
                    message = message.Replace('\n', ' ');
                }
                mesage_box.AppendText("Client: " + message + Environment.NewLine);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SendMessage();
            DisplayMessage(Chat_box.Text);
            Chat_box.Clear();
        }

        private void SendMessage()
        {
            string message = Chat_box.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                try
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send message: " + ex.Message);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try
            {
                connected = false;
                client?.Close();
                stream?.Close();
            }
            catch { }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void btn_open_server_Click(object sender, EventArgs e)
        {
            Chat_Server chatServerForm = new Chat_Server();
            chatServerForm.Show();
        }
    }
}

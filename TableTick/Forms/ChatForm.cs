using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTick.Forms
{
    public partial class ChatForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        TcpClientHandler tcpClientHandler;
        string currentUserId = "";
        string chatPartnerId = "";
        public class ChatMessage
        {
            public string SenderId { get; set; }
            public string ReceiverId { get; set; }
            public string Message { get; set; }
            public string Timestamp { get; set; }
        }
        public ChatForm()
        {
            InitializeComponent();
        }
        public ChatForm(string currentUserId)
        {
            InitializeComponent();
            this.currentUserId = currentUserId;
        }
        private void OnMessageReceived(string message)
        {
            lstMessages.Invoke((MethodInvoker)delegate
            {
                lstMessages.Items.Add($"{chatPartnerId}: {message}");
            });
        }
        private string GetChatId(string userId1, string userId2)
        {
            // Sắp xếp để tạo ID duy nhất cho mỗi cặp người dùng
            return string.Compare(userId1, userId2) < 0 ? $"{userId1}_{userId2}" : $"{userId2}_{userId1}";
        }
        private async void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            if (string.IsNullOrEmpty(message))
                return;

            var chatMessage = new ChatMessage
            {
                SenderId = currentUserId,
                ReceiverId = chatPartnerId,
                Message = message,
                Timestamp = DateTime.UtcNow.ToString("o")
            };

            // Gửi tin nhắn qua TCP
            await tcpClientHandler.SendMessage(message);

            // Ghi tin nhắn vào Firebase dưới mục riêng cho cặp người dùng này
            string chatId = GetChatId(currentUserId, chatPartnerId);
            await client.PushAsync($"messages/{chatId}", chatMessage);

            txtMessage.Clear();
            lstMessages.Items.Add($"{currentUserId}: {message}");
        }

        private async void btnSelectUser_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedItem != null)
            {
                chatPartnerId = ((KeyValuePair<string, string>)comboBoxUsers.SelectedItem).Key;
                MessageBox.Show($"Đã chọn người dùng: {((KeyValuePair<string, string>)comboBoxUsers.SelectedItem).Value}");

                // Tải lịch sử chat giữa currentUserId và chatPartnerId
                await LoadChatHistory(currentUserId, chatPartnerId);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để chat.");
            }
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async Task LoadUsers()
        {
            FirebaseResponse response = await client.GetAsync("users");
            Dictionary<string, Register> users = response.ResultAs<Dictionary<string, Register>>();

            comboBoxUsers.Items.Clear();
            foreach (var user in users)
            {
                if (user.Key != currentUserId) // Loại bỏ người dùng hiện tại khỏi danh sách
                {
                    comboBoxUsers.Items.Add(new KeyValuePair<string, string>(user.Key, user.Value.Username));
                }
            }

            comboBoxUsers.DisplayMember = "Value";
            comboBoxUsers.ValueMember = "Key";
        }
        private async Task LoadChatHistory(string userId1, string userId2)
        {
            string chatId = GetChatId(userId1, userId2);
            FirebaseResponse response = await client.GetAsync($"messages/{chatId}");
            Dictionary<string, ChatMessage> messages = response.ResultAs<Dictionary<string, ChatMessage>>();

            lstMessages.Items.Clear();
            if (messages != null)
            {
                foreach (var message in messages.Values.OrderBy(m => m.Timestamp))
                {
                    lstMessages.Items.Add($"{message.SenderId}: {message.Message}");
                }
            }
        }
        private async void ChatForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Kết nối Firebase thất bại. Vui lòng kiểm tra kết nối!");
                    return;
                }

                tcpClientHandler = new TcpClientHandler("127.0.0.1", 8888);
                _ = tcpClientHandler.ReceiveMessages(OnMessageReceived);

                // Load danh sách người dùng vào comboBoxUsers
                await LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace TableTick
{
    public partial class LoginMenu : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public LoginMenu()
        {
            InitializeComponent();
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPass.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu.");
                return;
            }

            try
            {
                // Lấy tất cả các UserId
                FirebaseResponse usersResponse = await client.GetAsync("users");

                if (usersResponse.Body != "null")
                {
                    var users = JsonConvert.DeserializeObject<Dictionary<string, Register>>(usersResponse.Body);

                    // Tìm UserId dựa trên Username
                    string userId = users.FirstOrDefault(u => u.Value.Username == textBoxUsername.Text).Key;

                    if (!string.IsNullOrEmpty(userId))
                    {
                        FirebaseResponse response = await client.GetAsync("users/" + userId);

                        if (response.Body != "null") // Kiểm tra xem response có dữ liệu hay không
                        {
                            // Chuyển đổi dữ liệu JSON thành đối tượng Register
                            Register register = response.ResultAs<Register>();

                            // Kiểm tra mật khẩu
                            if (textBoxPass.Text == register.Password)
                            {
                                UserSession.CurrentUserSession = new UserSession
                                {
                                    UserId = userId.ToString(),
                                    Username = register.Username,
                                    Email = register.Email,
                                    Fullname = register.Fullname,
                                    Password = register.Password,
                                    ConfirmPassword = register.ConfirmPassword,
                                    PhoneNumber = register.PhoneNumber
                                };

                                MessageBox.Show("Đăng nhập thành công");
                                this.Hide();
                                FormMenu formMenu = new FormMenu();
                                formMenu.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không chính xác.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên người dùng không tồn tại.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng không tồn tại.");
                    }
                }
                else
                {
                    MessageBox.Show("Hiện không có người dùng nào trong hệ thống.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối với Firebase: " + ex.Message);
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupMenu signupMenu = new SignupMenu();
            signupMenu.ShowDialog();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!!");
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

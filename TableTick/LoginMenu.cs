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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPass.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu.");
            }
            else
            {
                // Lấy dữ liệu từ Firebase cho tên người dùng được nhập vào
                FirebaseResponse response = client.Get("users/" + textBoxUsername.Text);

                if (response.Body != "null") // Kiểm tra xem response có dữ liệu hay không
                {
                    // Chuyển đổi dữ liệu JSON thành đối tượng Register
                    Register register = response.ResultAs<Register>();

                    // Kiểm tra mật khẩu
                    if (textBoxPass.Text == register.Password)
                    {
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
                MessageBox.Show(ex.Message+ "Check your connection!!");
            }
        }
    }
}

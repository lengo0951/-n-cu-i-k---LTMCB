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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TableTick
{
    public partial class SignupMenu : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public SignupMenu()
        {
            InitializeComponent();
        }
        public void ShowLoginMenu()
        {
            this.Hide();
            LoginMenu loginMenu = new LoginMenu();
            loginMenu.Show();
        }
        public void CheckPassword()
        {
            textBoxPass.Text = "";
            textBoxPass.PasswordChar = '*';
            textBoxPass.MaxLength = 14;
        }
        private void Singup_Load(object sender, EventArgs e)
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowLoginMenu();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLoginMenu();
        }
        static Random random = new Random();
        int otp = random.Next(100000, 999999);
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxUsername.Text) ||
                string.IsNullOrEmpty(textBoxPass.Text) || string.IsNullOrEmpty(textBoxConfirmPass.Text))
            {
                MessageBox.Show("Nhập đầy đủ tất cả các trường!");
            }
            else
            {
                // Kiểm tra xem mật khẩu và mật khẩu xác nhận có khớp nhau không
                if (textBoxPass.Text != textBoxConfirmPass.Text)
                {
                    MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp!");
                    return; // Thoát khỏi phương thức nếu mật khẩu không khớp
                }

                // Kiểm tra xem tên người dùng có chứa các ký tự không hợp lệ không
                if (textBoxUsername.Text.Contains(".") || textBoxUsername.Text.Contains("#") ||
                   textBoxUsername.Text.Contains("$") || textBoxUsername.Text.Contains("[") ||
                   textBoxUsername.Text.Contains("]"))
                {
                    MessageBox.Show("Tên người dùng không được chứa các ký tự không hợp lệ như '.', '#', '$', '[', ']'");
                    return; // Thoát khỏi phương thức nếu tên người dùng chứa ký tự không hợp lệ
                }
                var register = new Register
                {
                    Email = textBoxEmail.Text,
                    Username = textBoxUsername.Text,
                    Password = textBoxPass.Text,
                    ConfirmPassword = textBoxConfirmPass.Text,
                };
                // Sử dụng đúng định dạng của đường dẫn trong Firebase (chú ý thêm ".Text" sau textBoxUsername)
                SetResponse response =  client.Set("users/" + textBoxUsername.Text, register);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ConfirmEmail confirmEmail = new ConfirmEmail(textBoxEmail.Text);
                    confirmEmail.Show(); 
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đăng ký. Vui lòng thử lại sau.");
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

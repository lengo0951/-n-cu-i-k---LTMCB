using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTick.Forms.SettingChild
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private async void btnEditAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string fileName = Path.GetFileName(filePath);

                try
                {
                    // Upload the file to Firebase Storage
                    var stream = File.Open(filePath, FileMode.Open);
                    var task = new FirebaseStorage("tabletick-33966.appspot.com")
                        .Child("avatars")
                        .Child(UserSession.CurrentUserSession.UserId + "_" + fileName)
                        .PutAsync(stream);

                    // Track progress
                    task.Progress.ProgressChanged += (s, e) =>
                        Console.WriteLine($"Progress: {e.Percentage} %");

                    var downloadUrl = await task;

                    // Save the download URL to the user's profile
                    if (UserSession.CurrentUserSession != null)
                    {
                        UserSession.CurrentUserSession.AvatarUrl = downloadUrl;

                        // Update the user's profile in the Realtime Database
                        var updatedUser = new Register
                        {
                            Email = UserSession.CurrentUserSession.Email,
                            PhoneNumber = UserSession.CurrentUserSession.PhoneNumber,
                            Password = UserSession.CurrentUserSession.Password,
                            Fullname = UserSession.CurrentUserSession.Fullname,
                            Username = UserSession.CurrentUserSession.Username,
                            AvatarUrl = UserSession.CurrentUserSession.AvatarUrl // Ensure this property exists in the Register class
                        };

                        SetResponse response = await client.SetAsync("users/" + UserSession.CurrentUserSession.UserId, updatedUser);

                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("Cập nhật ảnh đại diện thành công.");
                            // Optionally, update the PictureBox to show the new avatar
                            pictureBoxAvatar.Image = Image.FromFile(filePath);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật ảnh đại diện thất bại. Vui lòng thử lại.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin người dùng. Vui lòng đăng nhập lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Kết nối Firebase thất bại. Vui lòng kiểm tra kết nối!");
                    return;
                }

                // Hiển thị thông tin người dùng từ UserSession
                if (UserSession.CurrentUserSession != null)
                {
                    textboxEmail.Text = UserSession.CurrentUserSession.Email;
                    textboxPhone.Text = UserSession.CurrentUserSession.PhoneNumber;
                    textboxPassword.Text = UserSession.CurrentUserSession.Password;
                    textboxFullname.Text = UserSession.CurrentUserSession.Fullname;
                    if (!string.IsNullOrEmpty(UserSession.CurrentUserSession.AvatarUrl))
                    {
                        pictureBoxAvatar.Load(UserSession.CurrentUserSession.AvatarUrl);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng. Vui lòng đăng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserSession.CurrentUserSession != null)
                {
                    // Lay thong tin nguoi dung thay doi
                    UserSession.CurrentUserSession.Email = textboxEmail.Text;
                    UserSession.CurrentUserSession.PhoneNumber = textboxPhone.Text;
                    UserSession.CurrentUserSession.Password = textboxPassword.Text;
                    UserSession.CurrentUserSession.Fullname = textboxFullname.Text;

                    // Tao doi tuong update
                    Register updatedUser = new Register
                    {
                        Email = UserSession.CurrentUserSession.Email,
                        PhoneNumber = UserSession.CurrentUserSession.PhoneNumber,
                        Password = UserSession.CurrentUserSession.Password,
                        Fullname = UserSession.CurrentUserSession.Fullname,
                        Username = UserSession.CurrentUserSession.Username,
                        AvatarUrl = UserSession.CurrentUserSession.AvatarUrl
                    };

                    // Cập nhật thông tin người dùng trong Firebase
                    SetResponse response = client.Set("users/" + UserSession.CurrentUserSession.UserId, updatedUser);

                    // Kiểm tra kết quả trả về từ Firebase
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại. Vui lòng thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng. Vui lòng đăng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

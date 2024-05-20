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
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;


namespace TableTick.Forms.Child
{
    public partial class Form_AddWork : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public Form_AddWork()
        {
            InitializeComponent();
        }
        
        private bool isFormValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxWorkTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề công việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxWorkTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxContent.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung công việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxContent.Focus();
                return false;
            }

            if (comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCategory.Focus();
                return false;
            }

            if (dtpStart.Value.Date > dtpEnd.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không thể sau ngày kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStart.Focus();
                return false;
            }

            return true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!isFormValid())
            {
                return;
            }

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Kiểm tra kết nối của bạn!!");
                return;
            }

            var worklist = new Worklist
            {
                Title = textBoxWorkTitle.Text,
                Content = textBoxContent.Text,
                Category = comboBoxCategory.SelectedItem.ToString(),
                Start = dtpStart.Value.Date,
                End = dtpEnd.Value.Date
            };

            FirebaseResponse response = client.Set("/worklist/" + textBoxWorkTitle.Text, worklist);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Đã thêm công việc mới", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseThis();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm công việc.");
            }
        }

        private void CloseThis()
        {
            UC_Works uC_Works = new UC_Works();
            uC_Works.LoadDataGridView();
            this.Dispose();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CloseThis();
        }
    }
}

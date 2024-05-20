using System;
using System.Threading.Tasks;
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
    public partial class UC_Works : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public UC_Works()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Child.Form_AddWork(), sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void UC_Works_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Kết nối Firebase thất bại. Vui lòng kiểm tra kết nối!");
                    return;
                }

                // Lấy dữ liệu từ Firebase
                FirebaseResponse response = client.Get("worklist");
                var data = JsonConvert.DeserializeObject<Dictionary<string, Worklist>>(response.Body);

                // Hiển thị dữ liệu trong DataGridView
                if (data != null && data.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Title");
                    dt.Columns.Add("Content");
                    dt.Columns.Add("Category");
                    dt.Columns.Add("Start");
                    dt.Columns.Add("End");

                    foreach (var item in data)
                    {
                        dt.Rows.Add(item.Value.Title, item.Value.Content, item.Value.Category,
                                    item.Value.Start.ToString("yyyy-MM-dd"), item.Value.End.ToString("yyyy-MM-dd"));
                    }

                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

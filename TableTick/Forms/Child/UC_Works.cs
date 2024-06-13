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
        DataTable workDataTable;
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
        private void CustomizeDataGridView()
        {
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.RowTemplate.Height = 30;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
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
                    workDataTable = new DataTable();
                    workDataTable.Columns.Add("Title");
                    workDataTable.Columns.Add("Content");
                    workDataTable.Columns.Add("Category");
                    workDataTable.Columns.Add("Start");
                    workDataTable.Columns.Add("End");

                    foreach (var item in data)
                    {
                        workDataTable.Rows.Add(item.Value.Title, item.Value.Content, item.Value.Category,
                                    item.Value.Start.ToString("yyyy-MM-dd"), item.Value.End.ToString("yyyy-MM-dd"));
                    }

                    dataGridView1.DataSource = workDataTable;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            CustomizeDataGridView();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sortBy = comboBoxSort.SelectedItem.ToString();
            if (workDataTable != null)
            {
                DataView dv = workDataTable.DefaultView;
                dv.Sort = sortBy;
                dataGridView1.DataSource = dv;
            }
        }
    }
}

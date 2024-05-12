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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!!");
            }
            var worklist = new Worklist
            {
                Content = textBoxContent.Text,
                Category = comboBoxCategory.ValueMember,
                Start = dtpStart.Value,
                End = dtpEnd.Value
            };
            FirebaseResponse response = client.Set("/worklist/" + textBoxWorkTitle.Text, worklist);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Up cong viec len thanh cong");
            }
            else
            {
                MessageBox.Show("Loi");
            }
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTick.Forms.Child
{
    public partial class UC_Works : UserControl
    {
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
    }
}

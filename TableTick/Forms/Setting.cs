using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace TableTick.Forms
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelSettingPane.Controls.Add(childForm);
            this.panelSettingPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingChild.EditProfile(), sender);
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingChild.Notification(), sender);
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingChild.Security(), sender);
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingChild.Appearance(), sender);
        }

        private void btnHelp_Click(object sender, EventArgs e)   
        {
            OpenChildForm(new Forms.SettingChild.Help(), sender);
        }
    }
}

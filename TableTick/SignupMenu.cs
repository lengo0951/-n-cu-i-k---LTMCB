using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTick
{
    public partial class SignupMenu : Form
    {
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //tao tai khoan
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

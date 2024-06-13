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
    public partial class ConfirmEmail : Form
    {
        public bool ConfirmationAccepted { get; private set; }

        private string email;
        private int code;
        private System.Windows.Forms.Timer closeTimer;
        private const string p = "advcjrrkrxxgcmul";

        public ConfirmEmail(string email)
        {
            InitializeComponent();
            this.email = email;
            Random rnd = new Random();
            code = rnd.Next(100000, 999999);
            closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 5000; // 5000 milliseconds = 5 seconds
        }
        private void ConfirmEmail_Load(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();

            message.From = new MailAddress("22520951@gm.uit.edu.vn");
            message.To.Add(new MailAddress(email));
            message.Subject = "TableTick Signup Confirmation";
            message.Body = "Mã OTP xác nhận mail la: " + code;

            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Timeout = 200000;
            smtpClient.Credentials = new NetworkCredential("22520951@gm.uit.edu.vn", p);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int input_code = int.Parse(textBoxOTP.Text);

            if (input_code == code)
            {
                ConfirmationAccepted = true;
                DialogResult = DialogResult.OK;
                closeTimer.Start();
            }
            else
            {
                MessageBox.Show("Ma OTP khong dung!");
            }
        }
        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.Close();
        }
    }
}

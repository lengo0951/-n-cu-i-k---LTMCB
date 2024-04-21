﻿namespace TableTick
{
    partial class SignupMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            textBoxConfirmPass = new TextBox();
            label1 = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            btnSignUp = new Button();
            textBoxPass = new TextBox();
            textBoxEmail = new TextBox();
            labelPass = new Label();
            labelEmail = new Label();
            labelLogin = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBoxConfirmPass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(textBoxPass);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(labelPass);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 396);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow;
            pictureBox2.Location = new Point(775, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.BackColor = Color.FromArgb(230, 231, 233);
            textBoxConfirmPass.Location = new Point(516, 253);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.Size = new Size(227, 25);
            textBoxConfirmPass.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(470, 230);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 21;
            label1.Text = "Confirm password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(230, 231, 233);
            textBoxUsername.Location = new Point(516, 147);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(227, 25);
            textBoxUsername.TabIndex = 20;
            textBoxUsername.TextChanged += textBox3_TextChanged;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(470, 124);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(69, 17);
            labelUsername.TabIndex = 19;
            labelUsername.Text = "Username";
            labelUsername.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.CornflowerBlue;
            linkLabel1.Location = new Point(685, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 17);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(530, 348);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 17;
            label2.Text = "Already have a account?";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaptionText;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.Font = new Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = SystemColors.HighlightText;
            btnSignUp.Location = new Point(516, 299);
            btnSignUp.Margin = new Padding(0);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(227, 35);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPass.Location = new Point(516, 197);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(227, 25);
            textBoxPass.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(230, 231, 233);
            textBoxEmail.Location = new Point(516, 89);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(227, 25);
            textBoxEmail.TabIndex = 13;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPass.Location = new Point(470, 174);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(66, 17);
            labelPass.TabIndex = 12;
            labelPass.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(470, 66);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 11;
            labelEmail.Text = "Email";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.DarkOrchid;
            labelLogin.Location = new Point(550, 34);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(176, 25);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "Create Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.admin_login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignupMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 396);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SignupMenu";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Singup";
            Load += Singup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button btnSignUp;
        private TextBox textBoxPass;
        private TextBox textBoxEmail;
        private Label labelPass;
        private Label labelEmail;
        private Label labelLogin;
        private TextBox textBoxConfirmPass;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
namespace TableTick
{
    partial class LoginMenu
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
            pictureBox1 = new PictureBox();
            labelLogin = new Label();
            labelUsername = new Label();
            labelPass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSignIn = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.admin_login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(477, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.DarkOrchid;
            labelLogin.Location = new Point(614, 92);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(223, 33);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Ready to Login";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(539, 151);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 23);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPass.Location = new Point(539, 228);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(85, 23);
            labelPass.TabIndex = 3;
            labelPass.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.Location = new Point(582, 181);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.Location = new Point(582, 259);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(726, 308);
            label1.Name = "label1";
            label1.Size = new Size(180, 23);
            label1.TabIndex = 6;
            label1.Text = "Forget Password";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.ActiveCaptionText;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = SystemColors.HighlightText;
            btnSignIn.Location = new Point(582, 347);
            btnSignIn.Margin = new Padding(0);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(259, 47);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(563, 425);
            label2.Name = "label2";
            label2.Size = new Size(167, 23);
            label2.TabIndex = 8;
            label2.Text = "Don't have account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.CornflowerBlue;
            linkLabel1.Location = new Point(736, 425);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(176, 23);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create a new account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 523);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(btnSignIn);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelPass);
            Controls.Add(labelUsername);
            Controls.Add(labelLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginMenu";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelLogin;
        private Label labelUsername;
        private Label labelPass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSignIn;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}
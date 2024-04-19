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
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.admin_login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.DarkOrchid;
            labelLogin.Location = new Point(530, 83);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(174, 25);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Ready to Login";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(465, 144);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(85, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPass.Location = new Point(465, 202);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(78, 20);
            labelPass.TabIndex = 3;
            labelPass.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(502, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(502, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 23);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(628, 262);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 6;
            label1.Text = "Forget Password";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.ActiveCaptionText;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Font = new Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = SystemColors.HighlightText;
            btnSignIn.Location = new Point(502, 299);
            btnSignIn.Margin = new Padding(0);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(227, 35);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Adobe Fan Heiti Std B", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(718, 9);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(86, 35);
            button2.TabIndex = 8;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 392);
            Controls.Add(button2);
            Controls.Add(btnSignIn);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelPass);
            Controls.Add(labelUsername);
            Controls.Add(labelLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginMenu";
            Text = "LoginMenu";
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
        private Button button2;
    }
}
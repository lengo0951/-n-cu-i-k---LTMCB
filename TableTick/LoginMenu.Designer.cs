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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            labelLogin = new Label();
            labelUsername = new Label();
            labelPass = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSignIn = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            textBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
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
            labelLogin.Location = new Point(537, 69);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(174, 25);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Ready to Login";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(472, 113);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(69, 17);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPass.Location = new Point(472, 171);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(66, 17);
            labelPass.TabIndex = 3;
            labelPass.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(635, 231);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 6;
            label1.Text = "Forget Password";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.ActiveCaptionText;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = SystemColors.HighlightText;
            btnSignIn.Location = new Point(509, 260);
            btnSignIn.Margin = new Padding(0);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(227, 35);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(493, 319);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 8;
            label2.Text = "Don't have account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.CornflowerBlue;
            linkLabel1.Location = new Point(644, 319);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(133, 17);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create a new account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderRadius = 10;
            textBoxUsername.CustomizableEdges = customizableEdges1;
            textBoxUsername.DefaultText = "";
            textBoxUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxUsername.Location = new Point(509, 133);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PasswordChar = '\0';
            textBoxUsername.PlaceholderText = "";
            textBoxUsername.SelectedText = "";
            textBoxUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBoxUsername.Size = new Size(233, 35);
            textBoxUsername.TabIndex = 26;
            // 
            // textBoxPass
            // 
            textBoxPass.BorderRadius = 10;
            textBoxPass.CustomizableEdges = customizableEdges3;
            textBoxPass.DefaultText = "";
            textBoxPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxPass.Location = new Point(509, 193);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '\0';
            textBoxPass.PlaceholderText = "";
            textBoxPass.SelectedText = "";
            textBoxPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBoxPass.Size = new Size(233, 35);
            textBoxPass.TabIndex = 27;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 392);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUsername);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(btnSignIn);
            Controls.Add(label1);
            Controls.Add(labelPass);
            Controls.Add(labelUsername);
            Controls.Add(labelLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginMenu";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelLogin;
        private Label labelUsername;
        private Label labelPass;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSignIn;
        private Label label2;
        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPass;
    }
}
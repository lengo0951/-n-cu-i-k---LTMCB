namespace TableTick.Forms.SettingChild
{
    partial class EditProfile
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            btnEditAvatar = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            textboxFullname = new Guna.UI2.WinForms.Guna2TextBox();
            textboxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            textboxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            textboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(43, 21);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(99, 24);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Edit Profile";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditAvatar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 65);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnEditAvatar
            // 
            btnEditAvatar.BorderRadius = 10;
            btnEditAvatar.CustomizableEdges = customizableEdges1;
            btnEditAvatar.DisabledState.BorderColor = Color.DarkGray;
            btnEditAvatar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditAvatar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditAvatar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditAvatar.FillColor = Color.Silver;
            btnEditAvatar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditAvatar.ForeColor = Color.White;
            btnEditAvatar.Location = new Point(579, 21);
            btnEditAvatar.Name = "btnEditAvatar";
            btnEditAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEditAvatar.Size = new Size(59, 32);
            btnEditAvatar.TabIndex = 2;
            btnEditAvatar.Text = "Edit";
            btnEditAvatar.Click += btnEditAvatar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile1;
            pictureBox1.Location = new Point(523, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(43, 78);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(78, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "First Name";
            // 
            // textboxFullname
            // 
            textboxFullname.BorderColor = Color.FromArgb(64, 64, 64);
            textboxFullname.BorderRadius = 5;
            textboxFullname.CustomizableEdges = customizableEdges3;
            textboxFullname.DefaultText = "";
            textboxFullname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textboxFullname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textboxFullname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textboxFullname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textboxFullname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxFullname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textboxFullname.ForeColor = Color.FromArgb(64, 64, 64);
            textboxFullname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxFullname.Location = new Point(43, 100);
            textboxFullname.Name = "textboxFullname";
            textboxFullname.PasswordChar = '\0';
            textboxFullname.PlaceholderForeColor = Color.Black;
            textboxFullname.PlaceholderText = "Enter your name";
            textboxFullname.SelectedText = "";
            textboxFullname.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textboxFullname.Size = new Size(538, 33);
            textboxFullname.TabIndex = 3;
            // 
            // textboxEmail
            // 
            textboxEmail.BorderColor = Color.Black;
            textboxEmail.BorderRadius = 5;
            textboxEmail.CustomizableEdges = customizableEdges5;
            textboxEmail.DefaultText = "";
            textboxEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textboxEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textboxEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textboxEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textboxEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textboxEmail.ForeColor = Color.FromArgb(64, 64, 64);
            textboxEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxEmail.Location = new Point(42, 169);
            textboxEmail.Name = "textboxEmail";
            textboxEmail.PasswordChar = '\0';
            textboxEmail.PlaceholderForeColor = Color.Black;
            textboxEmail.PlaceholderText = "";
            textboxEmail.SelectedText = "";
            textboxEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            textboxEmail.Size = new Size(539, 33);
            textboxEmail.TabIndex = 7;
            textboxEmail.TextChanged += guna2TextBox3_TextChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(43, 147);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(41, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Email";
            materialLabel4.Click += materialLabel4_Click;
            // 
            // textboxPhone
            // 
            textboxPhone.BorderColor = Color.FromArgb(64, 64, 64);
            textboxPhone.BorderRadius = 5;
            textboxPhone.CustomizableEdges = customizableEdges7;
            textboxPhone.DefaultText = "";
            textboxPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textboxPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textboxPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textboxPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textboxPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textboxPhone.ForeColor = Color.FromArgb(64, 64, 64);
            textboxPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxPhone.Location = new Point(42, 238);
            textboxPhone.Name = "textboxPhone";
            textboxPhone.PasswordChar = '\0';
            textboxPhone.PlaceholderForeColor = Color.Black;
            textboxPhone.PlaceholderText = "Enter your phone number";
            textboxPhone.SelectedText = "";
            textboxPhone.ShadowDecoration.CustomizableEdges = customizableEdges8;
            textboxPhone.Size = new Size(539, 33);
            textboxPhone.TabIndex = 9;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(43, 216);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(116, 19);
            materialLabel5.TabIndex = 8;
            materialLabel5.Text = "Contact Number";
            // 
            // textboxPassword
            // 
            textboxPassword.BorderColor = Color.FromArgb(64, 64, 64);
            textboxPassword.BorderRadius = 5;
            textboxPassword.CustomizableEdges = customizableEdges9;
            textboxPassword.DefaultText = "";
            textboxPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textboxPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textboxPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textboxPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textboxPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textboxPassword.ForeColor = Color.FromArgb(64, 64, 64);
            textboxPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxPassword.Location = new Point(42, 306);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.PasswordChar = '*';
            textboxPassword.PlaceholderForeColor = Color.Black;
            textboxPassword.PlaceholderText = "";
            textboxPassword.SelectedText = "";
            textboxPassword.ShadowDecoration.CustomizableEdges = customizableEdges10;
            textboxPassword.Size = new Size(539, 33);
            textboxPassword.TabIndex = 11;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(43, 284);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(71, 19);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = Color.FromArgb(128, 128, 255);
            btnCancel.BorderRadius = 10;
            btnCancel.CustomizableEdges = customizableEdges11;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.DimGray;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(43, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancel.Size = new Size(128, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            // 
            // btnUpdate
            // 
            btnUpdate.BorderColor = Color.FromArgb(128, 128, 255);
            btnUpdate.BorderRadius = 10;
            btnUpdate.CustomizableEdges = customizableEdges13;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.Black;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(199, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnUpdate.Size = new Size(128, 45);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Save";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 407);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(textboxPassword);
            Controls.Add(materialLabel6);
            Controls.Add(textboxPhone);
            Controls.Add(materialLabel5);
            Controls.Add(textboxEmail);
            Controls.Add(materialLabel4);
            Controls.Add(textboxFullname);
            Controls.Add(materialLabel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Guna.UI2.WinForms.Guna2TextBox textboxFullname;
        private Guna.UI2.WinForms.Guna2TextBox textboxEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Guna.UI2.WinForms.Guna2TextBox textboxPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Guna.UI2.WinForms.Guna2TextBox textboxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnEditAvatar;
    }
}
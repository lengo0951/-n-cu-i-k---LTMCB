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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            btnEditAvatar = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
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
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.FromArgb(64, 64, 64);
            guna2TextBox1.BorderRadius = 5;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(43, 100);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox1.PlaceholderText = "Quoc Ngo";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(215, 33);
            guna2TextBox1.TabIndex = 3;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.BorderColor = Color.FromArgb(64, 64, 64);
            guna2TextBox2.BorderRadius = 5;
            guna2TextBox2.CustomizableEdges = customizableEdges5;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(366, 100);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox2.PlaceholderText = "Le";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox2.Size = new Size(215, 33);
            guna2TextBox2.TabIndex = 5;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(366, 78);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(78, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Last Name";
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.BorderColor = Color.FromArgb(64, 64, 64);
            guna2TextBox3.BorderRadius = 5;
            guna2TextBox3.CustomizableEdges = customizableEdges7;
            guna2TextBox3.DefaultText = "";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Location = new Point(42, 169);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PasswordChar = '\0';
            guna2TextBox3.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox3.PlaceholderText = "22520951@gm.uit.edu.vn";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox3.Size = new Size(539, 33);
            guna2TextBox3.TabIndex = 7;
            guna2TextBox3.TextChanged += guna2TextBox3_TextChanged;
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
            // guna2TextBox4
            // 
            guna2TextBox4.BorderColor = Color.FromArgb(64, 64, 64);
            guna2TextBox4.BorderRadius = 5;
            guna2TextBox4.CustomizableEdges = customizableEdges9;
            guna2TextBox4.DefaultText = "";
            guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Location = new Point(42, 238);
            guna2TextBox4.Name = "guna2TextBox4";
            guna2TextBox4.PasswordChar = '\0';
            guna2TextBox4.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox4.PlaceholderText = "0878987686";
            guna2TextBox4.SelectedText = "";
            guna2TextBox4.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox4.Size = new Size(539, 33);
            guna2TextBox4.TabIndex = 9;
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
            // guna2TextBox5
            // 
            guna2TextBox5.BorderColor = Color.FromArgb(64, 64, 64);
            guna2TextBox5.BorderRadius = 5;
            guna2TextBox5.CustomizableEdges = customizableEdges11;
            guna2TextBox5.DefaultText = "";
            guna2TextBox5.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox5.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox5.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox5.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox5.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox5.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox5.Location = new Point(42, 306);
            guna2TextBox5.Name = "guna2TextBox5";
            guna2TextBox5.PasswordChar = '\0';
            guna2TextBox5.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBox5.PlaceholderText = "chubedan@123";
            guna2TextBox5.SelectedText = "";
            guna2TextBox5.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2TextBox5.Size = new Size(539, 33);
            guna2TextBox5.TabIndex = 11;
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
            btnCancel.CustomizableEdges = customizableEdges13;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.DimGray;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(43, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCancel.Size = new Size(128, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(128, 128, 255);
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges15;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Black;
            guna2Button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(199, 350);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Button1.Size = new Size(128, 45);
            guna2Button1.TabIndex = 13;
            guna2Button1.Text = "Save";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 407);
            Controls.Add(guna2Button1);
            Controls.Add(btnCancel);
            Controls.Add(guna2TextBox5);
            Controls.Add(materialLabel6);
            Controls.Add(guna2TextBox4);
            Controls.Add(materialLabel5);
            Controls.Add(guna2TextBox3);
            Controls.Add(materialLabel4);
            Controls.Add(guna2TextBox2);
            Controls.Add(materialLabel3);
            Controls.Add(guna2TextBox1);
            Controls.Add(materialLabel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            Text = "EditProfile";
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnEditAvatar;
    }
}
namespace TableTick.Forms
{
    partial class Setting
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
            btnHelp = new Button();
            btnAppearance = new Button();
            btnSecurity = new Button();
            btnNotification = new Button();
            btnEditProfile = new Button();
            panelSettingPane = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHelp);
            panel1.Controls.Add(btnAppearance);
            panel1.Controls.Add(btnSecurity);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(btnEditProfile);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 407);
            panel1.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Top;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Image = Properties.Resources.question;
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(0, 324);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(140, 81);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "     Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnAppearance
            // 
            btnAppearance.Dock = DockStyle.Top;
            btnAppearance.FlatAppearance.BorderSize = 0;
            btnAppearance.FlatStyle = FlatStyle.Flat;
            btnAppearance.Image = Properties.Resources.settings;
            btnAppearance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppearance.Location = new Point(0, 243);
            btnAppearance.Name = "btnAppearance";
            btnAppearance.Size = new Size(140, 81);
            btnAppearance.TabIndex = 5;
            btnAppearance.Text = "     Appearance";
            btnAppearance.TextAlign = ContentAlignment.MiddleLeft;
            btnAppearance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAppearance.UseVisualStyleBackColor = true;
            btnAppearance.Click += btnAppearance_Click;
            // 
            // btnSecurity
            // 
            btnSecurity.Dock = DockStyle.Top;
            btnSecurity.FlatAppearance.BorderSize = 0;
            btnSecurity.FlatStyle = FlatStyle.Flat;
            btnSecurity.Image = Properties.Resources.verified;
            btnSecurity.ImageAlign = ContentAlignment.MiddleLeft;
            btnSecurity.Location = new Point(0, 162);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Size = new Size(140, 81);
            btnSecurity.TabIndex = 4;
            btnSecurity.Text = "     Security";
            btnSecurity.TextAlign = ContentAlignment.MiddleLeft;
            btnSecurity.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSecurity.UseVisualStyleBackColor = true;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnNotification
            // 
            btnNotification.Dock = DockStyle.Top;
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.Image = Properties.Resources.notification;
            btnNotification.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotification.Location = new Point(0, 81);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(140, 81);
            btnNotification.TabIndex = 3;
            btnNotification.Text = "     Notification";
            btnNotification.TextAlign = ContentAlignment.MiddleLeft;
            btnNotification.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Dock = DockStyle.Top;
            btnEditProfile.FlatAppearance.BorderSize = 0;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Image = Properties.Resources.user;
            btnEditProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditProfile.Location = new Point(0, 0);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(140, 81);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "     Edit Profile";
            btnEditProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnEditProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // panelSettingPane
            // 
            panelSettingPane.Dock = DockStyle.Fill;
            panelSettingPane.Location = new Point(140, 0);
            panelSettingPane.Margin = new Padding(5);
            panelSettingPane.Name = "panelSettingPane";
            panelSettingPane.Size = new Size(687, 407);
            panelSettingPane.TabIndex = 1;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 407);
            Controls.Add(panelSettingPane);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Setting";
            Text = "Setting";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHelp;
        private Button btnAppearance;
        private Button btnSecurity;
        private Button btnNotification;
        private Button btnEditProfile;
        private Panel panelSettingPane;
    }
}
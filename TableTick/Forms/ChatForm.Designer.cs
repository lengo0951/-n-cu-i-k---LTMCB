namespace TableTick.Forms
{
    partial class ChatForm
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
            panel = new Panel();
            btnSelectUser = new Guna.UI2.WinForms.Guna2Button();
            comboBoxUsers = new MetroFramework.Controls.MetroComboBox();
            btnSend = new Guna.UI2.WinForms.Guna2Button();
            lstMessages = new ListBox();
            txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(btnSelectUser);
            panel.Controls.Add(comboBoxUsers);
            panel.Controls.Add(btnSend);
            panel.Controls.Add(lstMessages);
            panel.Controls.Add(txtMessage);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(811, 368);
            panel.TabIndex = 0;
            // 
            // btnSelectUser
            // 
            btnSelectUser.CustomizableEdges = customizableEdges1;
            btnSelectUser.DisabledState.BorderColor = Color.DarkGray;
            btnSelectUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSelectUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSelectUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSelectUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectUser.ForeColor = Color.White;
            btnSelectUser.Location = new Point(675, 82);
            btnSelectUser.Name = "btnSelectUser";
            btnSelectUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSelectUser.Size = new Size(124, 36);
            btnSelectUser.TabIndex = 4;
            btnSelectUser.Text = "Send";
            btnSelectUser.Click += btnSelectUser_Click;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.ItemHeight = 23;
            comboBoxUsers.Location = new Point(675, 12);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(121, 29);
            comboBoxUsers.TabIndex = 3;
            comboBoxUsers.UseSelectable = true;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // btnSend
            // 
            btnSend.CustomizableEdges = customizableEdges3;
            btnSend.DisabledState.BorderColor = Color.DarkGray;
            btnSend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(675, 320);
            btnSend.Name = "btnSend";
            btnSend.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSend.Size = new Size(124, 36);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.Click += btnSend_Click;
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.ItemHeight = 15;
            lstMessages.Location = new Point(12, 12);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(657, 304);
            lstMessages.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.BorderColor = Color.Black;
            txtMessage.CustomizableEdges = customizableEdges5;
            txtMessage.DefaultText = "";
            txtMessage.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMessage.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMessage.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Location = new Point(12, 320);
            txtMessage.Name = "txtMessage";
            txtMessage.PasswordChar = '\0';
            txtMessage.PlaceholderForeColor = Color.Black;
            txtMessage.PlaceholderText = "";
            txtMessage.SelectedText = "";
            txtMessage.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMessage.Size = new Size(657, 36);
            txtMessage.TabIndex = 0;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 368);
            Controls.Add(panel);
            Name = "ChatForm";
            Text = "ChatForm";
            Load += ChatForm_Load;
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private MetroFramework.Controls.MetroComboBox comboBoxUsers;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private ListBox lstMessages;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2Button btnSelectUser;
    }
}
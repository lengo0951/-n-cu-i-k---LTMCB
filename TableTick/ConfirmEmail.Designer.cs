namespace TableTick
{
    partial class ConfirmEmail
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
            textBoxOTP = new Guna.UI2.WinForms.Guna2TextBox();
            btnConfirm = new Button();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // textBoxOTP
            // 
            textBoxOTP.CustomizableEdges = customizableEdges1;
            textBoxOTP.DefaultText = "";
            textBoxOTP.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxOTP.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxOTP.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxOTP.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxOTP.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxOTP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOTP.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxOTP.Location = new Point(80, 45);
            textBoxOTP.Margin = new Padding(3, 4, 3, 4);
            textBoxOTP.Name = "textBoxOTP";
            textBoxOTP.PasswordChar = '●';
            textBoxOTP.PlaceholderText = "";
            textBoxOTP.SelectedText = "";
            textBoxOTP.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBoxOTP.Size = new Size(132, 35);
            textBoxOTP.TabIndex = 31;
            textBoxOTP.UseSystemPasswordChar = true;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.ActiveCaptionText;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = SystemColors.HighlightText;
            btnConfirm.Location = new Point(68, 103);
            btnConfirm.Margin = new Padding(0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(134, 35);
            btnConfirm.TabIndex = 29;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(21, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(218, 17);
            materialLabel1.TabIndex = 32;
            materialLabel1.Text = "Vui lòng nhập OTP xác nhận Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(21, 56);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(40, 24);
            materialLabel2.TabIndex = 33;
            materialLabel2.Text = "OTP";
            // 
            // ConfirmEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 157);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(textBoxOTP);
            Controls.Add(btnConfirm);
            Name = "ConfirmEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmEmail";
            TopMost = true;
            Load += ConfirmEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxOTP;
        private Button btnConfirm;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
namespace TableTick
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenu = new Panel();
            btnSetting = new Button();
            btnNote = new Button();
            btnTasks = new Button();
            btnCalendar = new Button();
            btnHome = new Button();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(70, 129, 244);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnNote);
            panelMenu.Controls.Add(btnTasks);
            panelMenu.Controls.Add(btnCalendar);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 487);
            panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSetting.ForeColor = SystemColors.ButtonHighlight;
            btnSetting.Image = Properties.Resources.settings1;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 320);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(198, 80);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "  Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnNote
            // 
            btnNote.Dock = DockStyle.Top;
            btnNote.FlatAppearance.BorderSize = 0;
            btnNote.FlatStyle = FlatStyle.Flat;
            btnNote.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNote.ForeColor = SystemColors.ButtonHighlight;
            btnNote.Image = (Image)resources.GetObject("btnNote.Image");
            btnNote.ImageAlign = ContentAlignment.MiddleLeft;
            btnNote.Location = new Point(0, 240);
            btnNote.Name = "btnNote";
            btnNote.Size = new Size(198, 80);
            btnNote.TabIndex = 5;
            btnNote.Text = " Pomodoro";
            btnNote.TextAlign = ContentAlignment.MiddleLeft;
            btnNote.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNote.UseVisualStyleBackColor = true;
            btnNote.Click += btnNote_Click;
            // 
            // btnTasks
            // 
            btnTasks.Dock = DockStyle.Top;
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTasks.ForeColor = SystemColors.ButtonHighlight;
            btnTasks.Image = Properties.Resources.Chat1;
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(0, 160);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(198, 80);
            btnTasks.TabIndex = 4;
            btnTasks.Text = "  Chat";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendar.ForeColor = SystemColors.ButtonHighlight;
            btnCalendar.Image = Properties.Resources.calendar1;
            btnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendar.Location = new Point(0, 80);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(198, 80);
            btnCalendar.TabIndex = 3;
            btnCalendar.Text = "  Calendar";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Image = Properties.Resources.home_button1;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(3, 0, 3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(198, 80);
            btnHome.TabIndex = 1;
            btnHome.Text = "  Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(70, 129, 244);
            panelTitleBar.BorderStyle = BorderStyle.FixedSingle;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(827, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(392, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(68, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(200, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(827, 407);
            panelDesktopPane.TabIndex = 2;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1027, 487);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableTick";
            Load += FormMenu_Load;
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnHome;
        private Button btnSetting;
        private Button btnCalendar;
        private Button btnTasks;
        private Button btnNote;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPane;
    }
}
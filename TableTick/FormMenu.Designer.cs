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
            panelMenu = new Panel();
            btnSetting = new Button();
            btnCalendar = new Button();
            btnTasks = new Button();
            btnPlan = new Button();
            btnNote = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGray;
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnCalendar);
            panelMenu.Controls.Add(btnTasks);
            panelMenu.Controls.Add(btnPlan);
            panelMenu.Controls.Add(btnNote);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 567);
            panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Image = Properties.Resources.gear;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 415);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(200, 67);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "     Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Image = Properties.Resources.calendar;
            btnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendar.Location = new Point(0, 348);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(200, 67);
            btnCalendar.TabIndex = 5;
            btnCalendar.Text = "     Calendar";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnTasks
            // 
            btnTasks.Dock = DockStyle.Top;
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Image = Properties.Resources.planning;
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(0, 281);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(200, 67);
            btnTasks.TabIndex = 4;
            btnTasks.Text = "     Tasks";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnPlan
            // 
            btnPlan.Dock = DockStyle.Top;
            btnPlan.FlatAppearance.BorderSize = 0;
            btnPlan.FlatStyle = FlatStyle.Flat;
            btnPlan.Image = Properties.Resources.writing;
            btnPlan.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlan.Location = new Point(0, 214);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(200, 67);
            btnPlan.TabIndex = 3;
            btnPlan.Text = "     Plan";
            btnPlan.TextAlign = ContentAlignment.MiddleLeft;
            btnPlan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnNote
            // 
            btnNote.Dock = DockStyle.Top;
            btnNote.FlatAppearance.BorderSize = 0;
            btnNote.FlatStyle = FlatStyle.Flat;
            btnNote.Image = Properties.Resources.star;
            btnNote.ImageAlign = ContentAlignment.MiddleLeft;
            btnNote.Location = new Point(0, 147);
            btnNote.Name = "btnNote";
            btnNote.Size = new Size(200, 67);
            btnNote.TabIndex = 2;
            btnNote.Text = "     Note";
            btnNote.TextAlign = ContentAlignment.MiddleLeft;
            btnNote.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNote.UseVisualStyleBackColor = true;
            btnNote.Click += btnNote_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Properties.Resources.home_logo;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 80);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 67);
            btnHome.TabIndex = 1;
            btnHome.Text = "     Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.ActiveCaption;
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(51, 28);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "TableTick";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(600, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(280, 28);
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
            panelDesktopPane.Size = new Size(600, 487);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMenu";
            Text = "FormMenu";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnHome;
        private Panel panelLogo;
        private Button btnSetting;
        private Button btnCalendar;
        private Button btnTasks;
        private Button btnPlan;
        private Button btnNote;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
    }
}
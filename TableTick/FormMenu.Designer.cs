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
            panel3 = new Panel();
            panel2 = new Panel();
            btnSun = new Button();
            btnSat = new Button();
            btnFri = new Button();
            btnThu = new Button();
            btnWed = new Button();
            btnTues = new Button();
            btnMon = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            nmNoti = new NumericUpDown();
            cbNoti = new CheckBox();
            btnToday = new Button();
            dateTimePicker1 = new DateTimePicker();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmNoti).BeginInit();
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
            panelMenu.Size = new Size(200, 489);
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
            panelTitleBar.Size = new Size(827, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(393, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(68, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(panel3);
            panelDesktopPane.Controls.Add(panel2);
            panelDesktopPane.Controls.Add(panel1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(200, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(827, 409);
            panelDesktopPane.TabIndex = 2;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // panel3
            // 
            panel3.Location = new Point(106, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(609, 271);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSun);
            panel2.Controls.Add(btnSat);
            panel2.Controls.Add(btnFri);
            panel2.Controls.Add(btnThu);
            panel2.Controls.Add(btnWed);
            panel2.Controls.Add(btnTues);
            panel2.Controls.Add(btnMon);
            panel2.Location = new Point(6, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 36);
            panel2.TabIndex = 1;
            // 
            // btnSun
            // 
            btnSun.Dock = DockStyle.Left;
            btnSun.Location = new Point(696, 0);
            btnSun.Name = "btnSun";
            btnSun.Size = new Size(122, 36);
            btnSun.TabIndex = 6;
            btnSun.Text = "Chủ nhật";
            btnSun.UseVisualStyleBackColor = true;
            // 
            // btnSat
            // 
            btnSat.Dock = DockStyle.Left;
            btnSat.Location = new Point(580, 0);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(116, 36);
            btnSat.TabIndex = 5;
            btnSat.Text = "Thứ 7";
            btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            btnFri.Dock = DockStyle.Left;
            btnFri.Location = new Point(464, 0);
            btnFri.Name = "btnFri";
            btnFri.Size = new Size(116, 36);
            btnFri.TabIndex = 4;
            btnFri.Text = "Thứ 6";
            btnFri.UseVisualStyleBackColor = true;
            // 
            // btnThu
            // 
            btnThu.Dock = DockStyle.Left;
            btnThu.Location = new Point(348, 0);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(116, 36);
            btnThu.TabIndex = 3;
            btnThu.Text = "Thứ 5";
            btnThu.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            btnWed.Dock = DockStyle.Left;
            btnWed.Location = new Point(232, 0);
            btnWed.Name = "btnWed";
            btnWed.Size = new Size(116, 36);
            btnWed.TabIndex = 2;
            btnWed.Text = "Thứ 4";
            btnWed.UseVisualStyleBackColor = true;
            // 
            // btnTues
            // 
            btnTues.Dock = DockStyle.Left;
            btnTues.Location = new Point(116, 0);
            btnTues.Name = "btnTues";
            btnTues.Size = new Size(116, 36);
            btnTues.TabIndex = 1;
            btnTues.Text = "Thứ 3";
            btnTues.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            btnMon.Dock = DockStyle.Left;
            btnMon.Location = new Point(0, 0);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(116, 36);
            btnMon.TabIndex = 0;
            btnMon.Text = "Thứ 2";
            btnMon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnToday);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 46);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmNoti);
            panel4.Controls.Add(cbNoti);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 46);
            panel4.TabIndex = 2;
            // 
            // nmNoti
            // 
            nmNoti.Location = new Point(131, 12);
            nmNoti.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmNoti.Name = "nmNoti";
            nmNoti.Size = new Size(61, 23);
            nmNoti.TabIndex = 3;
            // 
            // cbNoti
            // 
            cbNoti.AutoSize = true;
            cbNoti.Location = new Point(36, 12);
            cbNoti.Name = "cbNoti";
            cbNoti.Size = new Size(89, 19);
            cbNoti.TabIndex = 0;
            cbNoti.Text = "Notification";
            cbNoti.UseVisualStyleBackColor = true;
            cbNoti.CheckedChanged += cbNoti_CheckedChanged;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(673, 8);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(75, 23);
            btnToday.TabIndex = 1;
            btnToday.Text = "Hôm nay";
            btnToday.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(467, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1027, 489);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableTick";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmNoti).EndInit();
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
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btnSun;
        private Button btnSat;
        private Button btnFri;
        private Button btnThu;
        private Button btnWed;
        private Button btnTues;
        private Button btnMon;
        private Button btnToday;
        private DateTimePicker dateTimePicker1;
        private Panel panel4;
        private CheckBox cbNoti;
        private NumericUpDown nmNoti;
    }
}
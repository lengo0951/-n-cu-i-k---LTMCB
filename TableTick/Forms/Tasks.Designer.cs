namespace TableTick.Forms
{
    partial class Tasks
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
            panelJob = new Panel();
            dtpkDate = new DateTimePicker();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            mnsiAddJob = new ToolStripMenuItem();
            mnsiToday = new ToolStripMenuItem();
            btnTomorrow = new Button();
            btnYesterday = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelJob);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 370);
            panel1.TabIndex = 0;
            // 
            // panelJob
            // 
            panelJob.Location = new Point(12, 65);
            panelJob.Name = "panelJob";
            panelJob.Size = new Size(787, 293);
            panelJob.TabIndex = 0;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(392, 15);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(200, 23);
            dtpkDate.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnYesterday);
            panel3.Controls.Add(btnTomorrow);
            panel3.Controls.Add(dtpkDate);
            panel3.Controls.Add(menuStrip1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(787, 47);
            panel3.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsiAddJob, mnsiToday });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(787, 24);
            menuStrip1.TabIndex = 2;
            // 
            // mnsiAddJob
            // 
            mnsiAddJob.Name = "mnsiAddJob";
            mnsiAddJob.Size = new Size(73, 20);
            mnsiAddJob.Text = "Thêm việc";
            // 
            // mnsiToday
            // 
            mnsiToday.Name = "mnsiToday";
            mnsiToday.Size = new Size(68, 20);
            mnsiToday.Text = "Hôm nay";
            // 
            // btnTomorrow
            // 
            btnTomorrow.Location = new Point(598, 17);
            btnTomorrow.Name = "btnTomorrow";
            btnTomorrow.Size = new Size(75, 23);
            btnTomorrow.TabIndex = 3;
            btnTomorrow.Text = "Ngày mai";
            btnTomorrow.UseVisualStyleBackColor = true;
            // 
            // btnYesterday
            // 
            btnYesterday.Location = new Point(311, 15);
            btnYesterday.Name = "btnYesterday";
            btnYesterday.Size = new Size(75, 23);
            btnYesterday.TabIndex = 4;
            btnYesterday.Text = "Hôm qua";
            btnYesterday.UseVisualStyleBackColor = true;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 370);
            Controls.Add(panel1);
            Name = "Tasks";
            Text = "Tasks";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnYesterday;
        private Button btnTomorrow;
        private DateTimePicker dtpkDate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsiAddJob;
        private ToolStripMenuItem mnsiToday;
        private Panel panelJob;
    }
}
namespace TableTick.Forms
{
    partial class Calendar
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
            btnnext = new Button();
            btnprevious = new Button();
            daycontainer = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LBDATE = new Label();
            SuspendLayout();
            // 
            // btnnext
            // 
            btnnext.Location = new Point(839, 501);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(94, 29);
            btnnext.TabIndex = 0;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnprevious
            // 
            btnprevious.Location = new Point(739, 501);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(94, 29);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "Previous";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(12, 61);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(921, 434);
            daycontainer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 0;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 0;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(295, 9);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 0;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(411, 9);
            label4.Name = "label4";
            label4.Size = new Size(113, 24);
            label4.TabIndex = 0;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(549, 9);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 0;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(693, 9);
            label6.Name = "label6";
            label6.Size = new Size(67, 24);
            label6.TabIndex = 0;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(820, 9);
            label7.Name = "label7";
            label7.Size = new Size(89, 24);
            label7.TabIndex = 0;
            label7.Text = "Saturday";
            // 
            // LBDATE
            // 
            LBDATE.Font = new Font("Georgia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LBDATE.Location = new Point(145, 497);
            LBDATE.Name = "LBDATE";
            LBDATE.Size = new Size(588, 32);
            LBDATE.TabIndex = 0;
            LBDATE.Text = "MONTH YEAR";
            LBDATE.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 542);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(LBDATE);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(daycontainer);
            Controls.Add(btnprevious);
            Controls.Add(btnnext);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendar";
            Load += Calendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnnext;
        private Button btnprevious;
        private FlowLayoutPanel daycontainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label LBDATE;
    }
}
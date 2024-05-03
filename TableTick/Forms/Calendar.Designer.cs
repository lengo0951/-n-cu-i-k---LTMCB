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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(37, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1158, 423);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1101, 512);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1001, 512);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 38);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 0;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(228, 38);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 2;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(384, 38);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 3;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(548, 38);
            label4.Name = "label4";
            label4.Size = new Size(113, 24);
            label4.TabIndex = 4;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(739, 38);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 5;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(906, 38);
            label6.Name = "label6";
            label6.Size = new Size(67, 24);
            label6.TabIndex = 6;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1054, 38);
            label7.Name = "label7";
            label7.Size = new Size(89, 24);
            label7.TabIndex = 7;
            label7.Text = "Saturday";
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 553);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
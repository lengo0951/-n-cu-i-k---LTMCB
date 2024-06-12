namespace TableTick.Forms
{
    partial class Pomodoro
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
            start = new Button();
            stop = new Button();
            ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            status = new Label();
            button1 = new Button();
            tomatoWorking = new PictureBox();
            tomatoBreaking = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tomatoWorking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tomatoBreaking).BeginInit();
            SuspendLayout();
            // 
            // start
            // 
            start.BackColor = Color.Aquamarine;
            start.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            start.Location = new Point(26, 410);
            start.Margin = new Padding(3, 4, 3, 4);
            start.Name = "start";
            start.Size = new Size(105, 61);
            start.TabIndex = 1;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            start.Click += startButton_Click;
            // 
            // stop
            // 
            stop.BackColor = Color.LightCoral;
            stop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            stop.Location = new Point(152, 410);
            stop.Margin = new Padding(3, 4, 3, 4);
            stop.Name = "stop";
            stop.Size = new Size(105, 61);
            stop.TabIndex = 3;
            stop.Text = "Reset";
            stop.UseVisualStyleBackColor = false;
            stop.Click += resetButton_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            ProgressBar.FillThickness = 30;
            ProgressBar.Font = new Font("Microsoft Sans Serif", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            ProgressBar.ForeColor = Color.MediumSeaGreen;
            ProgressBar.Location = new Point(61, 31);
            ProgressBar.Margin = new Padding(3, 4, 3, 4);
            ProgressBar.Maximum = 1500;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.ProgressColor = Color.LightCoral;
            ProgressBar.ProgressColor2 = Color.Tomato;
            ProgressBar.ProgressThickness = 30;
            ProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressBar.ShowText = true;
            ProgressBar.Size = new Size(352, 352);
            ProgressBar.TabIndex = 29;
            ProgressBar.Text = "25:00";
            ProgressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            ProgressBar.Value = 1500;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(429, 11);
            status.Name = "status";
            status.Size = new Size(314, 45);
            status.TabIndex = 30;
            status.Text = "Pomodoro Timer";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(276, 421);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(84, 43);
            button1.TabIndex = 31;
            button1.Text = "Set to 5s";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tomatoWorking
            // 
            tomatoWorking.Image = Properties.Resources.giphy;
            tomatoWorking.Location = new Point(429, 67);
            tomatoWorking.Margin = new Padding(3, 4, 3, 4);
            tomatoWorking.Name = "tomatoWorking";
            tomatoWorking.Size = new Size(344, 361);
            tomatoWorking.SizeMode = PictureBoxSizeMode.Zoom;
            tomatoWorking.TabIndex = 32;
            tomatoWorking.TabStop = false;
            // 
            // tomatoBreaking
            // 
            tomatoBreaking.Image = Properties.Resources.tomatobreak;
            tomatoBreaking.Location = new Point(429, 67);
            tomatoBreaking.Margin = new Padding(3, 4, 3, 4);
            tomatoBreaking.Name = "tomatoBreaking";
            tomatoBreaking.Size = new Size(344, 361);
            tomatoBreaking.SizeMode = PictureBoxSizeMode.Zoom;
            tomatoBreaking.TabIndex = 33;
            tomatoBreaking.TabStop = false;
            // 
            // Pomodoro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 562);
            Controls.Add(tomatoBreaking);
            Controls.Add(tomatoWorking);
            Controls.Add(button1);
            Controls.Add(status);
            Controls.Add(ProgressBar);
            Controls.Add(stop);
            Controls.Add(start);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pomodoro";
            Text = "Pomodoro";
            ((System.ComponentModel.ISupportInitialize)tomatoWorking).EndInit();
            ((System.ComponentModel.ISupportInitialize)tomatoBreaking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private Label status;
        private Button button1;
        private PictureBox tomatoWorking;
        private PictureBox tomatoBreaking;
    }
}


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
            pause = new Button();
            stop = new Button();
            ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            status = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // start
            // 
            start.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            start.Location = new Point(12, 349);
            start.Name = "start";
            start.Size = new Size(105, 52);
            start.TabIndex = 1;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += startButton_Click;
            // 
            // pause
            // 
            pause.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pause.Location = new Point(174, 349);
            pause.Name = "pause";
            pause.Size = new Size(103, 52);
            pause.TabIndex = 2;
            pause.Text = "Pause";
            pause.UseVisualStyleBackColor = true;
            pause.Click += pauseButton_Click;
            // 
            // stop
            // 
            stop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            stop.Location = new Point(322, 349);
            stop.Name = "stop";
            stop.Size = new Size(101, 51);
            stop.TabIndex = 3;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += resetButton_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            ProgressBar.Font = new Font("Bungee", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            ProgressBar.ForeColor = Color.MediumSeaGreen;
            ProgressBar.Location = new Point(101, 29);
            ProgressBar.Maximum = 1500;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.ProgressColor = Color.LightCoral;
            ProgressBar.ProgressColor2 = Color.Tomato;
            ProgressBar.ProgressThickness = 30;
            ProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressBar.ShowText = true;
            ProgressBar.Size = new Size(250, 250);
            ProgressBar.TabIndex = 29;
            ProgressBar.Text = "25:00";
            ProgressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            ProgressBar.Value = 1500;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(555, 87);
            status.Name = "status";
            status.Size = new Size(0, 17);
            status.TabIndex = 30;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(341, 285);
            button1.Name = "button1";
            button1.Size = new Size(82, 44);
            button1.TabIndex = 31;
            button1.Text = "Set to 5s";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pomodoro
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 478);
            Controls.Add(button1);
            Controls.Add(status);
            Controls.Add(ProgressBar);
            Controls.Add(stop);
            Controls.Add(pause);
            Controls.Add(start);
            Name = "Pomodoro";
            Text = "Pomodoro ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button stop;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private Label status;
        private Button button1;
    }
}


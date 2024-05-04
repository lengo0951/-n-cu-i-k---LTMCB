namespace TableTick.Forms
{
    partial class Setting
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
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            metroPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.AutoScroll = true;
            metroPanel1.Controls.Add(panel1);
            metroPanel1.Dock = DockStyle.Left;
            metroPanel1.HorizontalScrollbar = true;
            metroPanel1.HorizontalScrollbarBarColor = false;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 0);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(265, 368);
            metroPanel1.TabIndex = 0;
            metroPanel1.VerticalScrollbar = true;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 158);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(78, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(93, 118);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Username";
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 368);
            Controls.Add(metroPanel1);
            Name = "Setting";
            Text = "Setting";
            metroPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
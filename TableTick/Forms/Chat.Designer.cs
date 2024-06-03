namespace TableTick.Forms
{
    partial class Chat
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
            mesage_box = new TextBox();
            btn_connect = new Button();
            btn_open_server = new Button();
            btn_send = new Button();
            Chat_box = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mesage_box);
            panel1.Controls.Add(btn_connect);
            panel1.Controls.Add(btn_open_server);
            panel1.Controls.Add(btn_send);
            panel1.Controls.Add(Chat_box);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 493);
            panel1.TabIndex = 0;
            // 
            // mesage_box
            // 
            mesage_box.Location = new Point(9, 17);
            mesage_box.Multiline = true;
            mesage_box.Name = "mesage_box";
            mesage_box.ReadOnly = true;
            mesage_box.Size = new Size(825, 385);
            mesage_box.TabIndex = 6;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(839, 196);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(74, 100);
            btn_connect.TabIndex = 5;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_open_server
            // 
            btn_open_server.Location = new Point(839, 17);
            btn_open_server.Name = "btn_open_server";
            btn_open_server.Size = new Size(75, 97);
            btn_open_server.TabIndex = 4;
            btn_open_server.Text = "Server";
            btn_open_server.UseVisualStyleBackColor = true;
            btn_open_server.Click += btn_open_server_Click;
            // 
            // btn_send
            // 
            btn_send.BackColor = SystemColors.Highlight;
            btn_send.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.ForeColor = SystemColors.WindowText;
            btn_send.Location = new Point(840, 405);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(75, 76);
            btn_send.TabIndex = 2;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // Chat_box
            // 
            Chat_box.Location = new Point(8, 407);
            Chat_box.Multiline = true;
            Chat_box.Name = "Chat_box";
            Chat_box.Size = new Size(826, 74);
            Chat_box.TabIndex = 1;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 493);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chat";
            Text = "Chat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_send;
        private TextBox Chat_box;
        private Button btn_open_server;
        private Button btn_connect;
        private TextBox mesage_box;
    }
}
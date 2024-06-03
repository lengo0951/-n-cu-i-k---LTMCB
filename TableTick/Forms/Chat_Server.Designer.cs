namespace TableTick.Forms
{
    partial class Chat_Server
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
            message_box_server = new TextBox();
            btn_listen = new Button();
            SuspendLayout();
            // 
            // message_box_server
            // 
            message_box_server.Location = new Point(38, 88);
            message_box_server.Multiline = true;
            message_box_server.Name = "message_box_server";
            message_box_server.ReadOnly = true;
            message_box_server.Size = new Size(723, 333);
            message_box_server.TabIndex = 0;
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(331, 27);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(133, 42);
            btn_listen.TabIndex = 1;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            // 
            // Chat_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_listen);
            Controls.Add(message_box_server);
            Name = "Chat_Server";
            Text = "Chat_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox message_box_server;
        private Button btn_listen;
    }
}
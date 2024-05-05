namespace TableTick.Forms
{
    partial class EventForm
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
            txdate = new TextBox();
            txevent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txdate
            // 
            txdate.BorderStyle = BorderStyle.FixedSingle;
            txdate.Enabled = false;
            txdate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txdate.Location = new Point(48, 82);
            txdate.Name = "txdate";
            txdate.Size = new Size(459, 25);
            txdate.TabIndex = 0;
            // 
            // txevent
            // 
            txevent.BorderStyle = BorderStyle.FixedSingle;
            txevent.Location = new Point(48, 166);
            txevent.Name = "txevent";
            txevent.Size = new Size(459, 27);
            txevent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 50);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 129);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 1;
            label2.Text = "Event";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(462, 207);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 248);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txevent);
            Controls.Add(txdate);
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventForm";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txdate;
        private TextBox txevent;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}
namespace TableTick.Forms
{
    partial class Plan
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
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            btn_Edit = new Button();
            btn_Delete = new Button();
            btn_Add = new Button();
            ID_col = new ColumnHeader();
            Taskname_col = new ColumnHeader();
            DateStart_col = new ColumnHeader();
            DateFinish = new ColumnHeader();
            Status_col = new ColumnHeader();
            Note_col = new ColumnHeader();
            listView1 = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 63);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(606, 12);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 1;
            button2.Text = "Ngày mai";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(66, 12);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 1;
            button1.Text = "Hôm qua";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(248, 15);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.Yellow;
            btn_Edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Edit.Location = new Point(713, 183);
            btn_Edit.Margin = new Padding(3, 2, 3, 2);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(76, 67);
            btn_Edit.TabIndex = 4;
            btn_Edit.Text = "Sửa";
            btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Red;
            btn_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Delete.Location = new Point(713, 294);
            btn_Delete.Margin = new Padding(3, 2, 3, 2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(76, 67);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.ActiveCaption;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.Location = new Point(713, 80);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(76, 67);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            // 
            // ID_col
            // 
            ID_col.Text = "ID";
            ID_col.Width = 40;
            // 
            // Taskname_col
            // 
            Taskname_col.Text = "Tên công việc";
            Taskname_col.TextAlign = HorizontalAlignment.Center;
            Taskname_col.Width = 150;
            // 
            // DateStart_col
            // 
            DateStart_col.Text = "Ngày bắt đầu";
            DateStart_col.TextAlign = HorizontalAlignment.Center;
            DateStart_col.Width = 140;
            // 
            // DateFinish
            // 
            DateFinish.Text = "Ngày kết thúc ";
            DateFinish.TextAlign = HorizontalAlignment.Center;
            DateFinish.Width = 140;
            // 
            // Status_col
            // 
            Status_col.Text = "Trạng thái";
            Status_col.TextAlign = HorizontalAlignment.Center;
            Status_col.Width = 140;
            // 
            // Note_col
            // 
            Note_col.Text = "Ghi chú";
            Note_col.TextAlign = HorizontalAlignment.Center;
            Note_col.Width = 140;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID_col, Taskname_col, DateStart_col, DateFinish, Status_col, Note_col });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(7, 80);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(659, 282);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Plan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 374);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "Plan";
            Text = "Plan";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button btn_Edit;
        private Button btn_Delete;
        private Button btn_Add;
        private ColumnHeader ID_col;
        private ColumnHeader Taskname_col;
        private ColumnHeader DateStart_col;
        private ColumnHeader DateFinish;
        private ColumnHeader Status_col;
        private ColumnHeader Note_col;
        private ListView listView1;
    }
}
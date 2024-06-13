namespace TableTick.Forms.Child
{
    partial class UC_Works
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            comboBoxSort = new MetroFramework.Controls.MetroComboBox();
            TextLabel = new Label();
            labelsort = new MaterialSkin.Controls.MaterialLabel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBoxSort);
            panel1.Controls.Add(TextLabel);
            panel1.Controls.Add(labelsort);
            panel1.Controls.Add(guna2Button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 55);
            panel1.TabIndex = 0;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.ItemHeight = 23;
            comboBoxSort.Items.AddRange(new object[] { "Title", "Content", "Category", "Start", "End" });
            comboBoxSort.Location = new Point(231, 12);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(296, 29);
            comboBoxSort.TabIndex = 6;
            comboBoxSort.UseSelectable = true;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged_1;
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(776, 0);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(40, 15);
            TextLabel.TabIndex = 5;
            TextLabel.Text = "Home";
            TextLabel.Visible = false;
            // 
            // labelsort
            // 
            labelsort.AutoSize = true;
            labelsort.Depth = 0;
            labelsort.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelsort.Location = new Point(159, 18);
            labelsort.MouseState = MaterialSkin.MouseState.HOVER;
            labelsort.Name = "labelsort";
            labelsort.Size = new Size(52, 19);
            labelsort.TabIndex = 2;
            labelsort.Text = "Sort By";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Dock = DockStyle.Left;
            guna2Button1.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.Add_properties;
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(0, 0);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(131, 55);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Add Work";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 342);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(817, 342);
            dataGridView1.TabIndex = 0;
            // 
            // metroContextMenu1
            // 
            metroContextMenu1.ImageScalingSize = new Size(20, 20);
            metroContextMenu1.Name = "metroContextMenu1";
            metroContextMenu1.Size = new Size(61, 4);
            // 
            // UC_Works
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Works";
            Padding = new Padding(5);
            Size = new Size(827, 407);
            Load += UC_Works_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel labelsort;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridView dataGridView1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private Label TextLabel;
        private MetroFramework.Controls.MetroComboBox comboBoxSort;
    }
}

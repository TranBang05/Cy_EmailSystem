namespace System.App.UserControls
{
    partial class UC_Employee
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
            ComponentModel.ComponentResourceManager resources = new ComponentModel.ComponentResourceManager(typeof(UC_Employee));
            toolStrip1 = new ToolStrip();
            btn_insert = new ToolStripButton();
            btn_update = new ToolStripButton();
            btn_delete = new ToolStripButton();
            btn_view = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            txt_Id = new TextBox();
            ID = new Label();
            cbx_department = new ComboBox();
            text_phone = new TextBox();
            txt_email = new TextBox();
            txt_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_insert, btn_update, btn_delete, btn_view });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(828, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btn_insert
            // 
            btn_insert.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_insert.Image = (Image)resources.GetObject("btn_insert.Image");
            btn_insert.ImageTransparentColor = Color.Magenta;
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(23, 22);
            btn_insert.Text = "Add";
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_update
            // 
            btn_update.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageTransparentColor = Color.Magenta;
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(23, 22);
            btn_update.Text = "Update";
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageTransparentColor = Color.Magenta;
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(23, 22);
            btn_delete.Text = "Delete";
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_view
            // 
            btn_view.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_view.Image = (Image)resources.GetObject("btn_view.Image");
            btn_view.ImageTransparentColor = Color.Magenta;
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(23, 22);
            btn_view.Text = "toolStripButton1";
            btn_view.Click += toolStripButton1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(txt_Id);
            splitContainer1.Panel1.Controls.Add(ID);
            splitContainer1.Panel1.Controls.Add(cbx_department);
            splitContainer1.Panel1.Controls.Add(text_phone);
            splitContainer1.Panel1.Controls.Add(txt_email);
            splitContainer1.Panel1.Controls.Add(txt_name);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(828, 437);
            splitContainer1.SplitterDistance = 127;
            splitContainer1.TabIndex = 1;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(189, 51);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(34, 23);
            txt_Id.TabIndex = 10;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(165, 59);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 9;
            ID.Text = "ID";
            // 
            // cbx_department
            // 
            cbx_department.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_department.FormattingEnabled = true;
            cbx_department.Location = new Point(582, 23);
            cbx_department.Name = "cbx_department";
            cbx_department.Size = new Size(141, 23);
            cbx_department.TabIndex = 8;
            // 
            // text_phone
            // 
            text_phone.Location = new Point(582, 83);
            text_phone.Name = "text_phone";
            text_phone.Size = new Size(141, 23);
            text_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(333, 83);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(132, 23);
            txt_email.TabIndex = 5;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(333, 23);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(132, 23);
            txt_name.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 91);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 91);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 31);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Department:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(691, 272);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UC_Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "UC_Employee";
            Size = new Size(828, 462);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_insert;
        private ToolStripButton btn_update;
        private ToolStripButton btn_delete;
        private SplitContainer splitContainer1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_name;
        private TextBox text_phone;
        private TextBox txt_email;
        private ComboBox cbx_department;
        private DataGridView dataGridView1;
        private ToolStripButton btn_view;
        private PictureBox pictureBox1;
        private TextBox txt_Id;
        private Label ID;
    }
}

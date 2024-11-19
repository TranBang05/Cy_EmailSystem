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
            splitContainer1 = new SplitContainer();
            toolStrip2 = new ToolStrip();
            btn_sendMail = new ToolStripButton();
            txt_date = new ToolStripTextBox();
            btn_add = new Button();
            btn_search = new Button();
            txt_search = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(toolStrip2);
            splitContainer1.Panel1.Controls.Add(btn_add);
            splitContainer1.Panel1.Controls.Add(btn_search);
            splitContainer1.Panel1.Controls.Add(txt_search);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.ForeColor = SystemColors.ActiveCaptionText;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1046, 549);
            splitContainer1.SplitterDistance = 506;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(30, 30);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btn_sendMail, txt_date });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1046, 38);
            toolStrip2.TabIndex = 12;
            toolStrip2.Text = "toolStrip2";
            // 
            // btn_sendMail
            // 
            btn_sendMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sendMail.ForeColor = SystemColors.ActiveCaptionText;
            btn_sendMail.Name = "btn_sendMail";
            btn_sendMail.Size = new Size(67, 35);
            btn_sendMail.Text = "Ngày:";
            // 
            // txt_date
            // 
            txt_date.BackColor = SystemColors.Control;
            txt_date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(114, 38);
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.LightSkyBlue;
            btn_add.BackgroundImageLayout = ImageLayout.Zoom;
            btn_add.Location = new Point(56, 50);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 28);
            btn_add.TabIndex = 11;
            btn_add.Text = "Thêm Mới";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.LightSkyBlue;
            btn_search.Location = new Point(861, 50);
            btn_search.Margin = new Padding(3, 4, 3, 4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(61, 31);
            btn_search.TabIndex = 10;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(611, 50);
            txt_search.Margin = new Padding(3, 4, 3, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(233, 27);
            txt_search.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 85);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(866, 361);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(511, 115);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // UC_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Employee";
            Size = new Size(1046, 549);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TextBox txt_search;
        private Button btn_add;
        private Button btn_search;
        private ToolStrip toolStrip2;
        private ToolStripButton btn_sendMail;
        private ToolStripTextBox txt_date;
    }
}

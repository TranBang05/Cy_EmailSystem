namespace System.App.UserControls
{
    partial class UC_ListMonth
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
            toolStrip1 = new ToolStrip();
            btn_sendMail = new ToolStripButton();
            txt_File = new ToolStripTextBox();
            panel1 = new Panel();
            btn_search = new Button();
            txt_search = new TextBox();
            textBox1 = new TextBox();
            lbx_error = new ListBox();
            btn_Send = new Button();
            cbx_header = new CheckBox();
            dgv_employee = new DataGridView();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((ComponentModel.ISupportInitialize)dgv_employee).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_sendMail, txt_File });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1007, 38);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_sendMail
            // 
            btn_sendMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sendMail.ForeColor = SystemColors.ActiveCaptionText;
            btn_sendMail.Name = "btn_sendMail";
            btn_sendMail.Size = new Size(67, 35);
            btn_sendMail.Text = "Ngày:";
            // 
            // txt_File
            // 
            txt_File.BackColor = SystemColors.Control;
            txt_File.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_File.Name = "txt_File";
            txt_File.ReadOnly = true;
            txt_File.Size = new Size(114, 38);
            txt_File.Click += txt_File_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbx_error);
            panel1.Controls.Add(btn_Send);
            panel1.Controls.Add(cbx_header);
            panel1.Controls.Add(dgv_employee);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 433);
            panel1.TabIndex = 7;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.LightSkyBlue;
            btn_search.Location = new Point(670, 13);
            btn_search.Margin = new Padding(3, 4, 3, 4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(61, 31);
            btn_search.TabIndex = 9;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(399, 15);
            txt_search.Margin = new Padding(3, 4, 3, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(233, 27);
            txt_search.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(750, 55);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "Lỗi Khi Gửi File";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // lbx_error
            // 
            lbx_error.FormattingEnabled = true;
            lbx_error.ItemHeight = 20;
            lbx_error.Location = new Point(750, 91);
            lbx_error.Name = "lbx_error";
            lbx_error.Size = new Size(213, 284);
            lbx_error.TabIndex = 6;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = Color.LimeGreen;
            btn_Send.ForeColor = SystemColors.ActiveCaptionText;
            btn_Send.Location = new Point(659, 381);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(71, 31);
            btn_Send.TabIndex = 3;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // cbx_header
            // 
            cbx_header.AutoSize = true;
            cbx_header.Location = new Point(670, 60);
            cbx_header.Name = "cbx_header";
            cbx_header.Size = new Size(18, 17);
            cbx_header.TabIndex = 2;
            cbx_header.UseVisualStyleBackColor = true;
            cbx_header.CheckedChanged += cbx_header_CheckedChanged;
            // 
            // dgv_employee
            // 
            dgv_employee.AllowUserToAddRows = false;
            dgv_employee.AllowUserToDeleteRows = false;
            dgv_employee.AllowUserToOrderColumns = true;
            dgv_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_employee.BackgroundColor = Color.White;
            dgv_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_employee.Location = new Point(55, 55);
            dgv_employee.Name = "dgv_employee";
            dgv_employee.ReadOnly = true;
            dgv_employee.RowHeadersWidth = 51;
            dgv_employee.RowTemplate.Height = 29;
            dgv_employee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_employee.Size = new Size(675, 321);
            dgv_employee.TabIndex = 0;
            dgv_employee.CellContentClick += dgv_employee_CellContentClick;
            // 
            // UC_ListMonth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "UC_ListMonth";
            Size = new Size(1007, 493);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ComponentModel.ISupportInitialize)dgv_employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_sendMail;
        private ToolStripTextBox txt_File;
        private Panel panel1;
        private DataGridView dgv_employee;
        private CheckBox cbx_header;
        private Button btn_Send;
        private ListBox lbx_error;
        private TextBox textBox1;
        private Button btn_search;
        private TextBox txt_search;
    }
}

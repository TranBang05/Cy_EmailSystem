namespace System.App.UserControls
{
    partial class UC_SendEmail
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
            ComponentModel.ComponentResourceManager resources = new ComponentModel.ComponentResourceManager(typeof(UC_SendEmail));
            txb_To = new TextBox();
            stb_Subject = new TextBox();
            btb_Body = new RichTextBox();
            toolbar = new ToolStrip();
            attachmentButton = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            btn_sendMail = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btn_AttachFile = new ToolStripButton();
            txt_File = new ToolStripTextBox();
            checkedListBox1 = new CheckedListBox();
            toolbar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txb_To
            // 
            txb_To.Location = new Point(10, 28);
            txb_To.Name = "txb_To";
            txb_To.PlaceholderText = "To";
            txb_To.Size = new Size(566, 23);
            txb_To.TabIndex = 0;
            txb_To.TextChanged += toTextBox_TextChanged;
            // 
            // stb_Subject
            // 
            stb_Subject.Location = new Point(10, 55);
            stb_Subject.Name = "stb_Subject";
            stb_Subject.PlaceholderText = "Subject";
            stb_Subject.Size = new Size(566, 23);
            stb_Subject.TabIndex = 1;
            // 
            // btb_Body
            // 
            btb_Body.AcceptsTab = true;
            btb_Body.Location = new Point(10, 84);
            btb_Body.Name = "btb_Body";
            btb_Body.Size = new Size(566, 231);
            btb_Body.TabIndex = 2;
            btb_Body.Text = "";
            // 
            // toolbar
            // 
            toolbar.Items.AddRange(new ToolStripItem[] { attachmentButton });
            toolbar.Location = new Point(0, 0);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(727, 25);
            toolbar.TabIndex = 4;
            // 
            // attachmentButton
            // 
            attachmentButton.Name = "attachmentButton";
            attachmentButton.Size = new Size(60, 22);
            attachmentButton.Text = "SendMail";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_sendMail, toolStripButton1, btn_AttachFile, txt_File });
            toolStrip1.Location = new Point(0, 325);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(727, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_sendMail
            // 
            btn_sendMail.Image = (Image)resources.GetObject("btn_sendMail.Image");
            btn_sendMail.Name = "btn_sendMail";
            btn_sendMail.Size = new Size(53, 22);
            btn_sendMail.Text = "Send";
            btn_sendMail.Click += toolStripButton3_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // btn_AttachFile
            // 
            btn_AttachFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_AttachFile.Image = (Image)resources.GetObject("btn_AttachFile.Image");
            btn_AttachFile.ImageTransparentColor = Color.Magenta;
            btn_AttachFile.Name = "btn_AttachFile";
            btn_AttachFile.RightToLeftAutoMirrorImage = true;
            btn_AttachFile.Size = new Size(23, 22);
            btn_AttachFile.Text = "File";
            btn_AttachFile.Click += btn_AttachFile_Click;
            // 
            // txt_File
            // 
            txt_File.Name = "txt_File";
            txt_File.Size = new Size(100, 25);
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(582, 30);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(112, 274);
            checkedListBox1.TabIndex = 6;
            // 
            // UC_SendEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBox1);
            Controls.Add(toolStrip1);
            Controls.Add(txb_To);
            Controls.Add(stb_Subject);
            Controls.Add(btb_Body);
            Controls.Add(toolbar);
            Name = "UC_SendEmail";
            Size = new Size(727, 350);
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_To;
        private TextBox stb_Subject;
        private RichTextBox btb_Body;
        private ToolStrip toolbar;
        private ToolStripButton attachmentButton;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton btn_AttachFile;
        private ToolStripButton btn_sendMail;
        private ToolStripTextBox txt_File;
        private CheckedListBox checkedListBox1;
    }
}

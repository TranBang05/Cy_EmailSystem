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
            clbEmails = new CheckedListBox();
            chkSelectAll = new CheckBox();
            txt_Cc = new TextBox();
            listMail = new ListBox();
            lbx_MailCc = new ListBox();
            toolbar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txb_To
            // 
            txb_To.Location = new Point(11, 37);
            txb_To.Margin = new Padding(3, 4, 3, 4);
            txb_To.Name = "txb_To";
            txb_To.PlaceholderText = "To";
            txb_To.Size = new Size(646, 27);
            txb_To.TabIndex = 0;
            txb_To.TextChanged += toTextBox_TextChanged;
            // 
            // stb_Subject
            // 
            stb_Subject.Location = new Point(11, 110);
            stb_Subject.Margin = new Padding(3, 4, 3, 4);
            stb_Subject.Name = "stb_Subject";
            stb_Subject.PlaceholderText = "Subject";
            stb_Subject.Size = new Size(646, 27);
            stb_Subject.TabIndex = 1;
            // 
            // btb_Body
            // 
            btb_Body.AcceptsTab = true;
            btb_Body.Location = new Point(11, 145);
            btb_Body.Margin = new Padding(3, 4, 3, 4);
            btb_Body.Name = "btb_Body";
            btb_Body.Size = new Size(646, 317);
            btb_Body.TabIndex = 2;
            btb_Body.Text = "";
            // 
            // toolbar
            // 
            toolbar.ImageScalingSize = new Size(20, 20);
            toolbar.Items.AddRange(new ToolStripItem[] { attachmentButton });
            toolbar.Location = new Point(0, 0);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(792, 27);
            toolbar.TabIndex = 4;
            // 
            // attachmentButton
            // 
            attachmentButton.Name = "attachmentButton";
            attachmentButton.Size = new Size(75, 24);
            attachmentButton.Text = "SendMail";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_sendMail, toolStripButton1, btn_AttachFile, txt_File });
            toolStrip1.Location = new Point(0, 479);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(792, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_sendMail
            // 
            btn_sendMail.Image = (Image)resources.GetObject("btn_sendMail.Image");
            btn_sendMail.Name = "btn_sendMail";
            btn_sendMail.Size = new Size(66, 24);
            btn_sendMail.Text = "Send";
            btn_sendMail.Click += toolStripButton3_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // btn_AttachFile
            // 
            btn_AttachFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_AttachFile.Image = (Image)resources.GetObject("btn_AttachFile.Image");
            btn_AttachFile.ImageTransparentColor = Color.Magenta;
            btn_AttachFile.Name = "btn_AttachFile";
            btn_AttachFile.RightToLeftAutoMirrorImage = true;
            btn_AttachFile.Size = new Size(29, 24);
            btn_AttachFile.Text = "File";
            btn_AttachFile.Click += btn_AttachFile_Click;
            // 
            // txt_File
            // 
            txt_File.Name = "txt_File";
            txt_File.Size = new Size(114, 27);
            // 
            // clbEmails
            // 
            clbEmails.FormattingEnabled = true;
            clbEmails.Location = new Point(665, 84);
            clbEmails.Margin = new Padding(3, 4, 3, 4);
            clbEmails.Name = "clbEmails";
            clbEmails.Size = new Size(99, 378);
            clbEmails.TabIndex = 6;
            clbEmails.Visible = false;
            clbEmails.SelectedIndexChanged += clbEmails_SelectedIndexChanged;
            // 
            // chkSelectAll
            // 
            chkSelectAll.AutoSize = true;
            chkSelectAll.Location = new Point(665, 40);
            chkSelectAll.Name = "chkSelectAll";
            chkSelectAll.Size = new Size(89, 24);
            chkSelectAll.TabIndex = 7;
            chkSelectAll.Text = "SelectAll";
            chkSelectAll.UseVisualStyleBackColor = true;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
            // 
            // txt_Cc
            // 
            txt_Cc.Location = new Point(11, 72);
            txt_Cc.Margin = new Padding(3, 4, 3, 4);
            txt_Cc.Name = "txt_Cc";
            txt_Cc.PlaceholderText = "Cc";
            txt_Cc.Size = new Size(646, 27);
            txt_Cc.TabIndex = 8;
            txt_Cc.TextChanged += txt_Cc_TextChanged;
            // 
            // listMail
            // 
            listMail.FormattingEnabled = true;
            listMail.ItemHeight = 20;
            listMail.Location = new Point(91, 62);
            listMail.Name = "listMail";
            listMail.Size = new Size(299, 204);
            listMail.TabIndex = 9;
            listMail.Visible = false;
            listMail.SelectedIndexChanged += listMail_SelectedIndexChanged;
            // 
            // lbx_MailCc
            // 
            lbx_MailCc.FormattingEnabled = true;
            lbx_MailCc.ItemHeight = 20;
            lbx_MailCc.Location = new Point(396, 94);
            lbx_MailCc.Name = "lbx_MailCc";
            lbx_MailCc.Size = new Size(261, 164);
            lbx_MailCc.TabIndex = 10;
            lbx_MailCc.Visible = false;
            lbx_MailCc.SelectedIndexChanged += lbx_MailCc_SelectedIndexChanged;
            // 
            // UC_SendEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbx_MailCc);
            Controls.Add(listMail);
            Controls.Add(txt_Cc);
            Controls.Add(chkSelectAll);
            Controls.Add(clbEmails);
            Controls.Add(toolStrip1);
            Controls.Add(txb_To);
            Controls.Add(stb_Subject);
            Controls.Add(btb_Body);
            Controls.Add(toolbar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_SendEmail";
            Size = new Size(792, 506);
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
        private CheckedListBox clbEmails;
        private CheckBox chkSelectAll;
        private TextBox txt_Cc;
        private ListBox listMail;
        private ListBox lbx_MailCc;
    }
}

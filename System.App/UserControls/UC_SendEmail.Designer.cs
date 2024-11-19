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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            toolbar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txb_To
            // 
            txb_To.Location = new Point(92, 28);
            txb_To.Name = "txb_To";
            txb_To.PlaceholderText = "To";
            txb_To.Size = new Size(484, 23);
            txb_To.TabIndex = 0;
            txb_To.TextChanged += toTextBox_TextChanged;
            // 
            // stb_Subject
            // 
            stb_Subject.Location = new Point(92, 82);
            stb_Subject.Name = "stb_Subject";
            stb_Subject.PlaceholderText = "Subject";
            stb_Subject.Size = new Size(484, 23);
            stb_Subject.TabIndex = 1;
            // 
            // btb_Body
            // 
            btb_Body.AcceptsTab = true;
            btb_Body.Location = new Point(10, 109);
            btb_Body.Name = "btb_Body";
            btb_Body.Size = new Size(566, 246);
            btb_Body.TabIndex = 2;
            btb_Body.Text = "";
            // 
            // toolbar
            // 
            toolbar.ImageScalingSize = new Size(20, 20);
            toolbar.Items.AddRange(new ToolStripItem[] { attachmentButton });
            toolbar.Location = new Point(0, 0);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(824, 25);
            toolbar.TabIndex = 4;
            toolbar.ItemClicked += toolbar_ItemClicked;
            // 
            // attachmentButton
            // 
            attachmentButton.ForeColor = SystemColors.ActiveCaptionText;
            attachmentButton.Name = "attachmentButton";
            attachmentButton.Size = new Size(60, 22);
            attachmentButton.Text = "SendMail";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_sendMail, toolStripButton1, btn_AttachFile, txt_File });
            toolStrip1.Location = new Point(0, 366);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(824, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_sendMail
            // 
            btn_sendMail.BackColor = Color.LimeGreen;
            btn_sendMail.Image = (Image)resources.GetObject("btn_sendMail.Image");
            btn_sendMail.Name = "btn_sendMail";
            btn_sendMail.Size = new Size(57, 24);
            btn_sendMail.Text = "Send";
            btn_sendMail.Click += toolStripButton3_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // btn_AttachFile
            // 
            btn_AttachFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_AttachFile.Image = (Image)resources.GetObject("btn_AttachFile.Image");
            btn_AttachFile.ImageTransparentColor = Color.Magenta;
            btn_AttachFile.Name = "btn_AttachFile";
            btn_AttachFile.RightToLeftAutoMirrorImage = true;
            btn_AttachFile.Size = new Size(24, 24);
            btn_AttachFile.Text = "File";
            btn_AttachFile.Click += btn_AttachFile_Click;
            // 
            // txt_File
            // 
            txt_File.Name = "txt_File";
            txt_File.Size = new Size(100, 27);
            // 
            // clbEmails
            // 
            clbEmails.FormattingEnabled = true;
            clbEmails.Location = new Point(582, 63);
            clbEmails.Name = "clbEmails";
            clbEmails.Size = new Size(198, 292);
            clbEmails.TabIndex = 6;
            clbEmails.Visible = false;
            clbEmails.SelectedIndexChanged += clbEmails_SelectedIndexChanged;
            // 
            // chkSelectAll
            // 
            chkSelectAll.AutoSize = true;
            chkSelectAll.ForeColor = SystemColors.ActiveCaptionText;
            chkSelectAll.Location = new Point(582, 30);
            chkSelectAll.Margin = new Padding(3, 2, 3, 2);
            chkSelectAll.Name = "chkSelectAll";
            chkSelectAll.Size = new Size(71, 19);
            chkSelectAll.TabIndex = 7;
            chkSelectAll.Text = "SelectAll";
            chkSelectAll.UseVisualStyleBackColor = true;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
            // 
            // txt_Cc
            // 
            txt_Cc.Location = new Point(92, 54);
            txt_Cc.Name = "txt_Cc";
            txt_Cc.PlaceholderText = "Cc";
            txt_Cc.Size = new Size(484, 23);
            txt_Cc.TabIndex = 8;
            txt_Cc.TextChanged += txt_Cc_TextChanged;
            // 
            // listMail
            // 
            listMail.FormattingEnabled = true;
            listMail.ItemHeight = 15;
            listMail.Location = new Point(78, 139);
            listMail.Margin = new Padding(3, 2, 3, 2);
            listMail.Name = "listMail";
            listMail.Size = new Size(262, 154);
            listMail.TabIndex = 9;
            listMail.Visible = false;
            listMail.SelectedIndexChanged += listMail_SelectedIndexChanged;
            // 
            // lbx_MailCc
            // 
            lbx_MailCc.FormattingEnabled = true;
            lbx_MailCc.ItemHeight = 15;
            lbx_MailCc.Location = new Point(346, 156);
            lbx_MailCc.Margin = new Padding(3, 2, 3, 2);
            lbx_MailCc.Name = "lbx_MailCc";
            lbx_MailCc.Size = new Size(229, 124);
            lbx_MailCc.TabIndex = 10;
            lbx_MailCc.Visible = false;
            lbx_MailCc.SelectedIndexChanged += lbx_MailCc_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(10, 28);
            button1.Name = "button1";
            button1.Size = new Size(50, 23);
            button1.TabIndex = 11;
            button1.Text = "To...";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(10, 57);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 12;
            button2.Text = "Cc...";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(10, 82);
            button3.Name = "button3";
            button3.Size = new Size(60, 23);
            button3.TabIndex = 13;
            button3.Text = "Subject: ";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // UC_SendEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "UC_SendEmail";
            Size = new Size(824, 393);
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

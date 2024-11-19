namespace System.App.Forms
{
    partial class EmailDialog
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
            ComponentModel.ComponentResourceManager resources = new ComponentModel.ComponentResourceManager(typeof(EmailDialog));
            txt_subject = new TextBox();
            rtxb_body = new RichTextBox();
            btn_send = new Button();
            btn_cancle = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            txt_cc = new TextBox();
            btn_cc = new Button();
            button1 = new Button();
            button2 = new Button();
            textPath = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // txt_subject
            // 
            txt_subject.Location = new Point(104, 58);
            txt_subject.Margin = new Padding(3, 2, 3, 2);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(521, 23);
            txt_subject.TabIndex = 7;
            // 
            // rtxb_body
            // 
            rtxb_body.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtxb_body.Location = new Point(33, 148);
            rtxb_body.Margin = new Padding(3, 2, 3, 2);
            rtxb_body.Name = "rtxb_body";
            rtxb_body.Size = new Size(592, 294);
            rtxb_body.TabIndex = 8;
            rtxb_body.Text = "";
            rtxb_body.TextChanged += rtxb_body_TextChanged;
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.LimeGreen;
            btn_send.ImageAlign = ContentAlignment.MiddleLeft;
            btn_send.Location = new Point(221, 446);
            btn_send.Margin = new Padding(3, 2, 3, 2);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(82, 32);
            btn_send.TabIndex = 9;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // btn_cancle
            // 
            btn_cancle.BackColor = Color.Tomato;
            btn_cancle.BackgroundImageLayout = ImageLayout.Center;
            btn_cancle.Location = new Point(328, 446);
            btn_cancle.Margin = new Padding(3, 2, 3, 2);
            btn_cancle.Name = "btn_cancle";
            btn_cancle.Size = new Size(82, 32);
            btn_cancle.TabIndex = 10;
            btn_cancle.Text = "Cancle";
            btn_cancle.UseVisualStyleBackColor = false;
            btn_cancle.Click += btn_cancle_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_cc
            // 
            txt_cc.Location = new Point(104, 22);
            txt_cc.Margin = new Padding(3, 2, 3, 2);
            txt_cc.Name = "txt_cc";
            txt_cc.Size = new Size(521, 23);
            txt_cc.TabIndex = 11;
            // 
            // btn_cc
            // 
            btn_cc.Location = new Point(33, 22);
            btn_cc.Margin = new Padding(3, 2, 3, 2);
            btn_cc.Name = "btn_cc";
            btn_cc.Size = new Size(57, 20);
            btn_cc.TabIndex = 12;
            btn_cc.Text = "Cc...";
            btn_cc.TextAlign = ContentAlignment.MiddleLeft;
            btn_cc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(33, 58);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(57, 20);
            button1.TabIndex = 13;
            button1.Text = "Subject: ";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(601, 98);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(24, 23);
            button2.TabIndex = 14;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textPath
            // 
            textPath.Location = new Point(104, 98);
            textPath.Margin = new Padding(3, 2, 3, 2);
            textPath.Name = "textPath";
            textPath.Size = new Size(491, 23);
            textPath.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(601, 150);
            button3.Name = "button3";
            button3.Size = new Size(24, 23);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EmailDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 486);
            Controls.Add(button3);
            Controls.Add(textPath);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_cc);
            Controls.Add(txt_cc);
            Controls.Add(btn_cancle);
            Controls.Add(btn_send);
            Controls.Add(rtxb_body);
            Controls.Add(txt_subject);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmailDialog";
            Text = "EmailDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_subject;
        private RichTextBox rtxb_body;
        private Button btn_send;
        private Button btn_cancle;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txt_cc;
        private Button btn_cc;
        private Button button1;
        private Button button2;
        private TextBox textPath;
        private Button button3;
    }
}
namespace System.App.Forms
{
    partial class AddMember
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
            btn_save = new Button();
            txt_position = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_cancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(txt_position);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(104, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 361);
            panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.MenuHighlight;
            btn_save.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.Location = new Point(179, 295);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(68, 39);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save ";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_position
            // 
            txt_position.Location = new Point(191, 228);
            txt_position.Name = "txt_position";
            txt_position.Size = new Size(265, 27);
            txt_position.TabIndex = 8;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(191, 175);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(265, 27);
            txt_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(191, 127);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(265, 27);
            txt_email.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(191, 82);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(265, 27);
            txt_name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(71, 232);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 4;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(71, 179);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(71, 131);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 86);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(71, 10);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 0;
            label1.Text = "Add New Member";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-1, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 467);
            panel2.TabIndex = 1;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Tomato;
            btn_cancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancel.Location = new Point(308, 295);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(71, 39);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "Cancel";
            btn_cancel.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 474);
            Controls.Add(panel2);
            Name = "AddMember";
            Text = "AddMember";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txt_position;
        private TextBox txt_phone;
        private TextBox txt_email;
        private TextBox txt_name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_save;
        private Panel panel2;
        private Button btn_cancel;
    }
}
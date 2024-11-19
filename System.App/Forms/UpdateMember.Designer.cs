namespace System.App.Forms
{
    partial class UpdateMember
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
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
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
            panel1.Location = new Point(125, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 335);
            panel1.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.MenuHighlight;
            btn_save.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.Location = new Point(85, 270);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(68, 39);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save ";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_position
            // 
            txt_position.Location = new Point(105, 215);
            txt_position.Name = "txt_position";
            txt_position.Size = new Size(206, 27);
            txt_position.TabIndex = 8;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(105, 167);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(206, 27);
            txt_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(105, 122);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(206, 27);
            txt_email.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(105, 72);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(206, 27);
            txt_name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 219);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 4;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 171);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 126);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 76);
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
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(260, 29);
            label1.TabIndex = 0;
            label1.Text = "Update New Member";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(184, 270);
            button1.Name = "button1";
            button1.Size = new Size(70, 39);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // UpdateMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 390);
            Controls.Add(panel1);
            Name = "UpdateMember";
            Text = "UpdateMember";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_save;
        private TextBox txt_position;
        private TextBox txt_phone;
        private TextBox txt_email;
        private TextBox txt_name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
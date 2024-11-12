namespace System.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentModel.ComponentResourceManager resources = new ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            EmailHistory = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            Employee = new Button();
            panel5 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panelContainer = new Panel();
            ((ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 118, 212);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(134, 433);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 113);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(EmailHistory);
            panel2.Location = new Point(3, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 39);
            panel2.TabIndex = 1;
            // 
            // EmailHistory
            // 
            EmailHistory.BackColor = Color.FromArgb(0, 118, 212);
            EmailHistory.ForeColor = SystemColors.ActiveCaptionText;
            EmailHistory.Location = new Point(-43, -10);
            EmailHistory.Name = "EmailHistory";
            EmailHistory.Size = new Size(197, 59);
            EmailHistory.TabIndex = 3;
            EmailHistory.Text = "  D/S Tháng";
            EmailHistory.UseVisualStyleBackColor = false;
            EmailHistory.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 39);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 118, 212);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(-43, -10);
            button2.Name = "button2";
            button2.Size = new Size(197, 59);
            button2.TabIndex = 3;
            button2.Text = "Template";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(Employee);
            panel4.Location = new Point(3, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 39);
            panel4.TabIndex = 3;
            // 
            // Employee
            // 
            Employee.BackColor = Color.FromArgb(0, 118, 212);
            Employee.ForeColor = SystemColors.ActiveCaptionText;
            Employee.Location = new Point(-43, -10);
            Employee.Name = "Employee";
            Employee.Size = new Size(197, 59);
            Employee.TabIndex = 3;
            Employee.Text = "  Nhân Viên";
            Employee.UseVisualStyleBackColor = false;
            Employee.Click += Employee_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(guna2Button1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(134, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(705, 46);
            panel5.TabIndex = 3;
            // 
            // guna2Button1
            // 
            guna2Button1.CheckedState.CustomBorderColor = Color.Black;
            guna2Button1.CheckedState.FillColor = Color.White;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(42, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(75, 23);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Email";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(134, 46);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(705, 387);
            panelContainer.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(839, 433);
            Controls.Add(panelContainer);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button EmailHistory;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button Employee;
        private Panel panel5;
        private Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

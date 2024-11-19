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
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            EmailHistory = new Button();
            panel3 = new Panel();
            Employee = new Button();
            panel5 = new Panel();
            label1 = new Label();
            panelContainer = new Panel();
            ((ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 55);
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
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(135, 493);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 103);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(EmailHistory);
            panel2.Location = new Point(3, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 39);
            panel2.TabIndex = 1;
            // 
            // EmailHistory
            // 
            EmailHistory.BackColor = Color.FromArgb(0, 118, 212);
            EmailHistory.Location = new Point(-43, 0);
            EmailHistory.Name = "EmailHistory";
            EmailHistory.Size = new Size(207, 49);
            EmailHistory.TabIndex = 3;
            EmailHistory.Text = "  D/S Tháng";
            EmailHistory.UseVisualStyleBackColor = false;
            EmailHistory.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(Employee);
            panel3.Location = new Point(3, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 45);
            panel3.TabIndex = 2;
            // 
            // Employee
            // 
            Employee.BackColor = Color.FromArgb(0, 118, 212);
            Employee.Location = new Point(-40, 0);
            Employee.Name = "Employee";
            Employee.Size = new Size(207, 42);
            Employee.TabIndex = 3;
            Employee.Text = "Employee";
            Employee.UseVisualStyleBackColor = false;
            Employee.Click += Employee_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(135, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(992, 46);
            panel5.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(401, 6);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 0;
            label1.Text = "CY - VIET NAM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.Window;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.ForeColor = Color.White;
            panelContainer.Location = new Point(135, 46);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(992, 447);
            panelContainer.TabIndex = 4;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1127, 493);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button EmailHistory;
        private Panel panel3;
        private Button Employee;
        private Panel panel5;
        private Panel panelContainer;
        private Label label1;
    }
}

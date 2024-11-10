using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;


namespace System.App.UserControls
{
    public partial class UC_SendEmail : UserControl
    {
        private Attachment emailAttachment = null;
        public UC_SendEmail()
        {
            InitializeComponent();
        }

        private void toTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_File.Text = dialog.FileName;
                emailAttachment = new Attachment(dialog.FileName);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Attachment attach = null; sendMail("bangtxhe163986@fpt.edu.vn", txb_To.Text, stb_Subject.Text, btb_Body.Text, emailAttachment);
                emailAttachment?.Dispose();
                MessageBox.Show("Email đã được gửi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
            }
        }

        void sendMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (file != null)
            {
                mess.Attachments.Add(file);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("bangtxhe163986@fpt.edu.vn", "idyfhcztobfsamjh");
            client.Send(mess);
        }
    }
}

using System;
using System.BusinessAccess.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace System.App.UserControls
{
    public partial class UC_SendEmail : UserControl
    {
        private List<Attachment> emailAttachments = new List<Attachment>();
        private readonly IEmployeeService _employeeService;

        public UC_SendEmail(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            InitializeComponent();
        }
        private void toTextBox_TextChanged(object sender, EventArgs e)
        {
            var inputs = txb_To.Text.Split(' ');
            string currentInput = inputs.Last().Trim().ToLower();
            List<string> emailList = _employeeService.GetEmail();
            var suggest = emailList
                .Where(email => email.Contains(currentInput) &&
                        !txb_To.Text.ToLower().Contains(email.ToLower()))
                .ToList();
            if (suggest.Count > 0)
            {
                listMail.Visible = true;
                listMail.Items.Clear();
                UncheckAllEmails();
                foreach (var email in suggest)
                {
                    listMail.Items.Add(email);
                }
                listMail.Location = new Point(txb_To.Left, txb_To.Bottom);
                listMail.BringToFront();
            }
            else
            {
                listMail.Visible = false;
            }
        }

        private void txt_Cc_TextChanged(object sender, EventArgs e)
        {
            var inputs = txt_Cc.Text.Split(' ');
            string currentInput = inputs.Last().Trim().ToLower();
            List<string> emailList = _employeeService.GetEmail();
            var suggest = emailList
                .Where(email => email.Contains(currentInput) &&
                        !txt_Cc.Text.ToLower().Contains(email.ToLower()))
                .ToList();
            if (suggest.Count > 0)
            {
                lbx_MailCc.Visible = true;
                lbx_MailCc.Items.Clear();
                foreach (var email in suggest)
                {
                    lbx_MailCc.Items.Add(email);
                }
                lbx_MailCc.Location = new Point(txt_Cc.Left, txt_Cc.Bottom);
                lbx_MailCc.BringToFront();
            }
            else
            {
                lbx_MailCc.Visible = false;
            }
        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in dialog.FileNames)
                {
                    emailAttachments.Add(new Attachment(fileName));
                    txt_File.Text += fileName + " ";
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listEmail = GetEmailsForSending();

                if (listEmail.Count == 0)
                {
                    MessageBox.Show("Không có email nào để gửi.");
                    return;
                }
                foreach (var email in listEmail)
                {
                    char firstChar = char.ToLower(email[0]);
                    List<Attachment> matchingAttachments = new List<Attachment>();
                    foreach (var attachment in emailAttachments)
                    {
                        if (char.ToLower(Path.GetFileName(attachment.Name)[0]) == firstChar)
                        {
                            matchingAttachments.Add(attachment);
                        }
                    }
                    if (matchingAttachments.Any())
                    {
                        sendMail("bangtxhe163986@fpt.edu.vn", new List<string> { email }, stb_Subject.Text, btb_Body.Text, matchingAttachments);
                    }
                }
                foreach (var attachment in emailAttachments)
                {
                    attachment.Dispose();
                }
                emailAttachments.Clear();
                MessageBox.Show("Email đã được gửi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
            }
        }
        private List<string> GetSelectedEmails()
        {
            List<string> selectedEmails = new List<string>();
            foreach (var item in clbEmails.CheckedItems)
            {
                selectedEmails.Add(item.ToString());
            }
            return selectedEmails;
        }
        private List<string> GetEmailsForSending()
        {
            List<string> emails = new List<string>();
            if (!string.IsNullOrWhiteSpace(txb_To.Text))
            {
                emails = txb_To.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(email => email.Trim())
                                    .ToList();
            }
            else
            {
                emails = GetSelectedEmails();
            }

            return emails;
        }
        void sendMail(string from, List<string> toList, string subject, string message, List<Attachment> attachments = null)
        {
            MailMessage mess = new MailMessage();
            mess.From = new MailAddress(from);
            if (toList.Count > 0)
            {
                mess.To.Add(toList[0]);
                for (int i = 1; i < toList.Count; i++)
                {
                    mess.CC.Add(toList[i]);
                }
            }
            mess.Subject = subject;
            mess.Body = message;
            foreach (var attachment in attachments)
            {
                mess.Attachments.Add(attachment);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("bangtxhe163986@fpt.edu.vn", "idyfhcztobfsamjh");
            client.Send(mess);
        }

        private async void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool check = chkSelectAll.Checked;
            clbEmails.Visible = check;
            txb_To.Clear();
            listMail.Visible = false;
            txt_Cc.Clear();
            lbx_MailCc.Visible = false;

            if (check)
            {
                await LoadAndCheckEmailList();
            }
            else
            {
                UncheckAllEmails();
            }
        }

        private async Task LoadAndCheckEmailList()
        {
            List<string> emailList = await _employeeService.GetEmployeeEmailsAsync();
            clbEmails.Items.Clear();
            foreach (var email in emailList)
            {
                int index = clbEmails.Items.Add(email);
                clbEmails.SetItemChecked(index, true);
            }
        }

        private void UncheckAllEmails()
        {
            for (int i = 0; i < clbEmails.Items.Count; i++)
            {
                clbEmails.SetItemChecked(i, false);
            }
        }

        private void clbEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void listMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMail.SelectedItem != null)
            {
                string selectedEmail = listMail.SelectedItem.ToString();
                var inputs = txb_To.Text.Split(' ').ToList();
                inputs[inputs.Count - 1] = selectedEmail;
                txb_To.Text = string.Join(" ", inputs) + " ";
                txb_To.SelectionStart = txb_To.Text.Length;
                listMail.Visible = false;
            }
        }

        private void lbx_MailCc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_MailCc.SelectedItem != null)
            {
                string selectedEmail = lbx_MailCc.SelectedItem.ToString();
                var inputs = txt_Cc.Text.Split(' ').ToList();
                inputs[inputs.Count - 1] = selectedEmail;
                txt_Cc.Text = string.Join(" ", inputs) + " ";
                txt_Cc.SelectionStart = txb_To.Text.Length;
                listMail.Visible = false;
            }
        }

        private void toolbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

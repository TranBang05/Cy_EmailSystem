using System.App.UserControls;
using System.BusinessAccess.Service;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Security.RightsManagement;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace System.App.Forms
{
    public partial class EmailDialog : Form
    {
        public List<string> RecipientEmails = new List<string>();
        public List<string> CcEmails = new List<string>();
        private readonly IEmployeeService _employeeService;
        public List<string> listName = new List<string>();
        public List<Attachment> EmailAttachments = new List<Attachment>();
        private UC_ListMonth _listMonthControl;
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public EmailDialog(UC_ListMonth listMonthControl, IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            _listMonthControl = listMonthControl;
            InitializeComponent();
            LoadCcEmails();
            LoadSubject();
            LoadBody();
        }
        private async Task LoadCcEmails()
        {
            try
            {
                CcEmails = _employeeService.GetEmail();
                txt_cc.Clear();
                for (int i = 0; i < CcEmails.Count; i++)
                {
                    txt_cc.Text += CcEmails[i];
                    if (i < CcEmails.Count - 1)
                    {
                        txt_cc.Text += "; ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách CC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sendMail_Click(object sender, EventArgs e)
        {
            Subject = txt_subject.Text;
            Body = rtxb_body.Text;
            SendEmails();
            DialogResult = DialogResult.OK;
        }

        private async void SendEmails()
        {
            List<string> log = new List<string>();
            List<Attachment> listFile = new List<Attachment>(EmailAttachments);

            if (!listFile.Any())
            {
                MessageBox.Show("Không có tệp đính kèm nào để gửi!");
                return;
            }

                try
                {
                    var ccEmails = txt_cc.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(email => email.Trim())
                                     .ToList();
                    bool sendEmail = false;
                    for (int i = 0; i < RecipientEmails.Count; i++)
                    {
                        var email = RecipientEmails[i];
                        var employeeName = listName[i].ToLower();
                        var ccEmailsFilter = ccEmails.Where(cc => !cc.Equals(email, StringComparison.OrdinalIgnoreCase)).ToList();
                        List<Attachment> matchingAttachments = listFile
                            .Where(att => Path.GetFileNameWithoutExtension(att.Name)
                                .ToLower()
                                .StartsWith(employeeName))
                            .ToList();
                        string companyLogoUrl = "https://static.topcv.vn/company_logos/cBDttOofMW81bo5SnGrqt0TVHAuXGrjN_1639724204____b40590a73dc7a4ccc405b850b0614a1b.png";
                        if (matchingAttachments.Any())
                        {
                            sendMail("bangtxhe163986@fpt.edu.vn", new List<string> { email }, Subject, Body, companyLogoUrl, ccEmailsFilter, matchingAttachments);
                            foreach (var match in matchingAttachments)
                            {
                                listFile.Remove(match);
                            }
                            sendEmail = true;
                        }
                        else
                        {
                            log.Add($"Nhân Viên: {listName[i]}");
                        }
                    }
                    foreach (var attachment in EmailAttachments)
                    {
                        attachment.Dispose();
                    }
                    EmailAttachments.Clear();
                    if (!sendEmail)
                    {
                        MessageBox.Show("folder không có tệp file phù hợp nào được gửi đi.");
                    }

                    
                
                    if (listFile.Any())
                    {
                        foreach (var unmatchedFile in listFile)
                        {
                            log.Add($"File: {unmatchedFile.Name}");
                        }
                    }
                
                    MessageBox.Show("Email đã được gửi thành công!");
                
                    if (log.Any())
                    {
                    _listMonthControl.DisplayErrors(log);
                    }

            }
                catch (Exception ex)
                {
                    log.Add("Lỗi khi gửi email: " + ex.Message);
                    _listMonthControl.DisplayErrors(log);
                }
        }



            void sendMail(string from, List<string> toList, string subject, string message, string imageUrl, List<string> ccList = null, List<Attachment> attachments = null)
            {
                MailMessage mess = new MailMessage();
                mess.From = new MailAddress(from);
                foreach (var to in toList)
                {
                    mess.To.Add(to);
                }

                if (ccList != null)
                {
                    foreach (var cc in ccList)
                    {
                        mess.CC.Add(cc);
                    }
                }
                mess.Subject = subject;
                mess.Body = message;
                string htmlBody = "<html><body>";
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    htmlBody += $"<img src=\"{imageUrl}\" alt=\"Company Logo\" style=\"width:200px; height:auto;\"><br>";
                }
                string content = rtxb_body.Text;
                content = content.Replace("CY Vietnam", "<span style=\"color:blue;\">CY Vietnam</span>");
                content = content.Replace("Công ty TNHH Phát triển Phần mềm CY Việt Nam", "<span style=\"color:blue;\">Công ty TNHH Phát triển Phần mềm CY Việt Nam</span>");
                content = content.Replace("Ms. TRAN BICH LIEN ADMINISTRATOR", "<span style=\"color:#0000FF;\">Ms. TRAN BICH LIEN ADMINISTRATOR</span>");
                htmlBody += $"<p>{content.Replace("\n", "<br>")}</p>";
                htmlBody += "</body></html>";
                mess.Body = htmlBody;
                mess.IsBodyHtml = true;
                foreach (var attachment in attachments)
                {
                    mess.Attachments.Add(attachment);
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential("bangtxhe163986@fpt.edu.vn", "idyfhcztobfsamjh")
                };
                client.Send(mess);
            }
        

        private async Task LoadSubject()
        {
            if (txt_subject != null)
            {
                DateTime currentDate = DateTime.Now;
                DateTime previousMonth = currentDate.AddMonths(-1);
                string time = previousMonth.ToString("MM-yyyy");
                txt_subject.Text = $"[CY Việt Nam][Phiếu Lương Tháng {time}]";
            }
        }
            
        private async Task LoadBody()
        {
            if (rtxb_body != null)
            {
                rtxb_body.Clear();
                rtxb_body.AppendText("Ms. TRẦN BÍCH LIÊN ADMINISTRATOR | CY Vietnam\r\n");
                rtxb_body.AppendText("Công ty TNHH Phát triển Phần mềm CY Việt Nam\n");
                rtxb_body.AppendText("Office  : +84 24-2248-9977\n");
                rtxb_body.AppendText("Mobile : +84 38-206-5699    Email : b.tranlien2810@cyglobal.net\n");
                rtxb_body.AppendText("SNS:  https://www.facebook.com/cysoftwarevietnam/ \n");
                rtxb_body.AppendText("Website: www.cyvietnam.com\n");
                rtxb_body.AppendText("Address : \n");
                rtxb_body.AppendText("안양 본사 | 경기도 안양시 동안구 시민대로 248번길 25, 경기창조산업안양센터 504/505/506/406호 [14067]\r\n");
                rtxb_body.AppendText("       호남 지사 | 광주광역시 북구 추암로 249, 광주이노비즈센터 410호  [61003] \r\n");
                rtxb_body.AppendText("       Vietnam Corp. | 11th, Detech Tower, 8 Ton That Thuyet, My Dinh 2, Nam Tu Liem, Ha Noi, Vietnam");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = dialog.SelectedPath;
                    string[] files = Directory.GetFiles(folderPath);
                    foreach (string fileName in files)
                    {
                        EmailAttachments.Add(new Attachment(fileName));
                        textPath.Text += Path.GetFileName(fileName) + " ";
                    }
                }
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            Subject = txt_subject.Text;
            Body = rtxb_body.Text;
            SendEmails();
            DialogResult = DialogResult.OK;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadBody();
        }
        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void rtxb_body_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

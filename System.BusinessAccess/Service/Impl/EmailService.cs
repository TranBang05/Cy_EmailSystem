using System;
using System.BusinessAccess.Dto.Request;
using System.BusinessAccess.Dto.Response;
using System.Collections.Generic;
using System.DataAccess.Repository;
using System.Database.Entity;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace System.BusinessAccess.Service.Impl
{
    public class EmailService : IEmailService
    {
        private readonly IEmailHistoryRepository _emailHistoryRepository;
        private readonly IMapper _mapper;

        public EmailService(IEmailHistoryRepository emailHistoryRepository, IMapper mapper)
        {
            _emailHistoryRepository = emailHistoryRepository;
            _mapper = mapper;
        }
        public async Task<EmailResponse> SendEmailAsync(EmailRequest emailRequest)
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("bangtxhe163986@fpt.edu.vn", "idyfhcztobfsamjh");

                var mailMessage = new MailMessage("bangtxhe163986@fpt.edu.vn", emailRequest.To, emailRequest.Subject, emailRequest.Body);

                if (!string.IsNullOrEmpty(emailRequest.AttachmentPath))
                {
                    mailMessage.Attachments.Add(new Attachment(emailRequest.AttachmentPath));
                }
                await client.SendMailAsync(mailMessage);
            }
            var emailHistory = _mapper.Map<EmailHistory>(emailRequest);
            emailHistory.SentAt = DateTime.Now; 
            await _emailHistoryRepository.InsertAsync(emailHistory);
            return _mapper.Map<EmailResponse>(emailHistory);
        }
    }
}

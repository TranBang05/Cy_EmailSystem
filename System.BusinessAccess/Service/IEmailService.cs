using System;
using System.BusinessAccess.Dto.Request;
using System.BusinessAccess.Dto.Response;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BusinessAccess.Service
{
    public interface IEmailService
    {
        Task<EmailResponse> SendEmailAsync(EmailRequest emailRequest);
    }
}

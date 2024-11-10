using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BusinessAccess.Dto.Response
{
    public class EmailResponse
    {
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime SentAt { get; set; }
    }
}

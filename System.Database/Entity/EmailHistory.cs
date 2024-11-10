using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Database.Entity
{
    public class EmailHistory
    {
        public int EmailHistoryID { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime SentAt { get; set; }
        public string? AttachmentPath { get; set; }
        public ICollection<EmailRecipient>? Recipients { get; set; }
    }
}

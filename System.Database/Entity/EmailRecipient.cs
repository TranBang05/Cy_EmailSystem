using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Database.Entity
{
    public class EmailRecipient
    {
        public int EmailHistoryID { get; set; }
        public int EmployeeID { get; set; }
        public string? Status { get; set; }
        public string? ErrorMessage { get; set; }
        public EmailHistory? EmailHistory { get; set; }
        public Employee? Employee { get; set; }
    }
}

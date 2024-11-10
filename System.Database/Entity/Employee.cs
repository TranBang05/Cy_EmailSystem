using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Database.Entity
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Position { get; set; }
        public DateTime? Created_At { get; set; }
        public Department? Department { get; set; }
        public ICollection<EmailRecipient>? EmailRecipients { get; set; }
    }
}

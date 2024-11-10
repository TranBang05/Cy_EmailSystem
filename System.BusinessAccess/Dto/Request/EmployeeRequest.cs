using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BusinessAccess.Dto.Request
{
    public class EmployeeRequest
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BusinessAccess.Dto.Response
{
    public class EmployeeResponse
    {
        public int EmployeeID { get; set; }
        public string? DepartmentName { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}

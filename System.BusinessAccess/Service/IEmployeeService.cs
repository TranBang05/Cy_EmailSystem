using System;
using System.BusinessAccess.Dto.Request;
using System.BusinessAccess.Dto.Response;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BusinessAccess.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeResponse>> GetAllEmployeesAsync();
        Task<EmployeeResponse> GetEmployeeByIdAsync(int id);
        Task<EmployeeResponse> AddEmployeeAsync(EmployeeRequest request);
        Task<EmployeeResponse> UpdateEmployeeAsync(EmployeeRequest request);
        Task<bool> DeleteEmployeeAsync(int id);
        Task<List<string>> GetEmployeeEmailsAsync();
        List<string> GetEmail();
    }
}

using System;
using System.Collections.Generic;
using System.Database.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace System.DataAccess.Repository.Impl
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(CyDbContext context) : base(context) { }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            //dsfdsfsdf
            return await _context.Employees
                              .Include(e => e.Department) 
                              .ToListAsync();
        }

        public List<Employee> getAll()
        {
            return _context.Employees.ToList();
        }

        public List<string> GetEmail()
        {
            var employees = getAll();
            return employees.Select(e => e.Email).ToList();
        }

        public async Task<List<string>> GetEmployeeEmailsAsync()
        {
            var employees = await GetAllEmployeesAsync();
            return employees.Select(e => e.Email).ToList();
        }
    }
}

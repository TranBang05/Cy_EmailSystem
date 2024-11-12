using System;
using System.BusinessAccess.Dto.Request;
using System.BusinessAccess.Dto.Response;
using System.Collections.Generic;
using System.DataAccess.Repository;
using System.Database.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace System.BusinessAccess.Service.Impl
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<EmployeeResponse> AddEmployeeAsync(EmployeeRequest request)
        {
            var employee = _mapper.Map<Employee>(request);
            var addedEmployee = await _employeeRepository.InsertAsync(employee);
            return _mapper.Map<EmployeeResponse>(addedEmployee);
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null) return false;

            await _employeeRepository.DeleteAsync(employee);
            await _employeeRepository.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<EmployeeResponse>> GetAllEmployeesAsync()
        {
            var employees = await _employeeRepository.GetAllEmployeesAsync();
            return _mapper.Map<IEnumerable<EmployeeResponse>>(employees);
        }

        public async Task<EmployeeResponse> GetEmployeeByIdAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            return employee != null ? _mapper.Map<EmployeeResponse>(employee) : null;
        }

        public List<string> GetEmail()
        {
            var emails =  _employeeRepository.GetEmail();
            return emails;
        }

        public async Task<EmployeeResponse> UpdateEmployeeAsync(EmployeeRequest request)
        {
            var employee = await _employeeRepository.GetByIdAsync(request.EmployeeID);
            if (employee == null) return null;

            _mapper.Map(request, employee);
            var updatedEmployee = await _employeeRepository.UpdateAsync(employee);
            return _mapper.Map<EmployeeResponse>(updatedEmployee);
        }

        public async Task<List<string>> GetEmployeeEmailsAsync()
        {
            var emails = await _employeeRepository.GetEmployeeEmailsAsync();
            return emails;
        }
    }
}

using System;
using System.BusinessAccess.Dto.Response;
using System.Collections.Generic;
using System.DataAccess.Repository;
using System.DataAccess.Repository.Impl;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace System.BusinessAccess.Service.Impl
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRrpository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository departmentRrpository, IMapper mapper)
        {
           _departmentRrpository = departmentRrpository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DepartmentResponse>> GetAllAsync()
        {
            var departments = await _departmentRrpository.GetAllAsync();
            return _mapper.Map<IEnumerable<DepartmentResponse>>(departments);
        }
    }
}

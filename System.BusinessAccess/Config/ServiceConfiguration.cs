using System;
using System.BusinessAccess.Dto.Mapper;
using System.BusinessAccess.Service.Impl;
using System.BusinessAccess.Service;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.DataAccess.Repository;
using System.DataAccess.Repository.Impl;

namespace System.BusinessAccess.Config
{
    public static class ServiceConfiguration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MyMapper));
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository,EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRespository>();
            services.AddScoped<IDepartmentService, DepartmentService>();
        }
    }
}

using System;
using System.BusinessAccess.Dto.Request;
using System.BusinessAccess.Dto.Response;
using System.Collections.Generic;
using System.Database.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace System.BusinessAccess.Dto.Mapper
{
    public class MyMapper:Profile
    {
        public MyMapper() {

            CreateMap<Employee, EmployeeResponse>()
           .ForMember(x => x.EmployeeID, opt => opt.MapFrom(src => src.EmployeeID))
           .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name))
           .ForMember(x => x.Email, opt => opt.MapFrom(src => src.Email))
           .ForMember(x => x.Phone, opt => opt.MapFrom(src => src.Phone))
           .ForMember(x => x.DepartmentName, opt => opt.MapFrom(src => src.Department.DepartmentName));

            CreateMap<EmployeeRequest, Employee>();

            CreateMap<Department, DepartmentResponse>();

            CreateMap<EmailRequest, EmailHistory>()
            .ForMember(dest => dest.SentAt, opt => opt.MapFrom(src => DateTime.Now));

            CreateMap<EmailHistory, EmailResponse>();

        }

    }
    
}

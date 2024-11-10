using System;
using System.Collections.Generic;
using System.Database.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Repository.Impl
{
    public class DepartmentRespository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRespository(CyDbContext context) : base(context) { }
    }
}

using System;
using System.Collections.Generic;
using System.Database.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Repository.Impl
{
    public class EmailHistoryRespository : BaseRepository<EmailHistory>, IEmailHistoryRepository
    {
        public EmailHistoryRespository(CyDbContext context) : base(context)
        {
        }
    }
}

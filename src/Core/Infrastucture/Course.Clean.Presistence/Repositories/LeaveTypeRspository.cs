using Course.Clean.Application.Contracts;
using Course.Clean.Domain.Entities;
using Course.Clean.Presistence.DatabaseContext;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Presistence.Repositories
{
    public class LeaveTypeRspository : GenericRepository<LeavTypes> ,ILeaveTypeRepository
    {
        public LeaveTypeRspository(CleanDBContext context):base(context)
        {

        }
    }
}

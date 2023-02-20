using AutoMapper;

using Course.Clean.Application.Features.LeaveTypes.Queries.GetAllLeaveTypes;
using Course.Clean.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Application.MappingProfiles
{
    public class LeaveTypeProfile :Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypesDTO, LeavTypes>().ReverseMap();
        }
    }
}

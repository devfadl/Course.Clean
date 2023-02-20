using AutoMapper;

using Course.Clean.Application.Contracts;
using Course.Clean.Application.Features.LeaveTypes.Queries.GetAllLeaveTypes;

using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Application.Features.LeaveTypes.Queries.GetLeaveTypeById
{
    public record GetLeaveTypeByIdQuery(Guid id) : IRequest<LeaveTypesDTO>;
    public class GetLeaveTypeByIdqueryHandler : IRequestHandler<GetLeaveTypeByIdQuery, LeaveTypesDTO>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _repo;

        public GetLeaveTypeByIdqueryHandler(IMapper mapper, ILeaveTypeRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<LeaveTypesDTO> Handle(GetLeaveTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var leaveType = await _repo.GetByIdAsync(request.id);
            var data = _mapper.Map<LeaveTypesDTO>(leaveType);
            return data;
        }
    }
}

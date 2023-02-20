using AutoMapper;

using Course.Clean.Application.Contracts;

using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Application.Features.LeaveTypes.Queries.GetAllLeaveTypes
{
    public record GetAllLeaveTypesQuery : IRequest<List<LeaveTypesDTO>>;

    public class GetAllLeaveTypesQueryQueryHandler : IRequestHandler<GetAllLeaveTypesQuery, List<LeaveTypesDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _repo;

        public GetAllLeaveTypesQueryQueryHandler(IMapper mapper, ILeaveTypeRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<List<LeaveTypesDTO>> Handle(GetAllLeaveTypesQuery request, CancellationToken cancellationToken)
        {
            var result = await _repo.GetAllAsync();
            var data = _mapper.Map<List<LeaveTypesDTO>>(result);
            return data;
        }
    }
}

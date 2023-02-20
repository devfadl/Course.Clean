using AutoMapper;
using Course.Clean.Application.Contracts;
using Course.Clean.Domain.Entities;

using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Application.Features.LeaveTypes.Commands
{
    public class CreateLeaveTypeCommand :IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
    }
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _repo;

        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Guid> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
           //validation
           var data = _mapper.Map<LeavTypes>(request);
            await _repo.AddAsync(data);
            return data.Id;
        }
    }
}

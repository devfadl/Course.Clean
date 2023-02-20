using Course.Clean.Domain.Entities;

namespace Course.Clean.Application.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeavTypes>
    {
        Task<IReadOnlyList<LeavTypes>> GetAllAsync();
        Task<LeavTypes> GetByIdAsync(Guid id);
        Task AddAsync(LeavTypes entity);
        Task UpdateAsync(LeavTypes entity);
        Task DeleteAsync(LeavTypes entity);
    }
}

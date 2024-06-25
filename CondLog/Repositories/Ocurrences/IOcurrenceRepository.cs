using CondLog.Models;

namespace CondLog.Repositories.Ocurrences
{
    public interface IOcurrenceRepository
    {
        Task<List<Ocurrence>> GetAllAsync();
        Task<Ocurrence> GetByIdAsync(Guid id);
        Task AddAsync(Ocurrence ocurrence);
        Task UpdateAsync(Ocurrence ocurrence);
        Task SaveChangesAsync();
    }
}

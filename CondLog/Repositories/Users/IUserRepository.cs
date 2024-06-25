using CondLog.Models;

namespace CondLog.Repositories.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteByIdAsync(string id);
        Task SaveChangesAsync();
    }
}

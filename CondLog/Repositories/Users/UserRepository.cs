using CondLog.Data;
using CondLog.Models;
using Microsoft.EntityFrameworkCore;

namespace CondLog.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public UserRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(User user)
        {
            await _dbcontext.Users.AddAsync(user);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbcontext.Users
                .Where(u => u.IsDeleted.Equals(false))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _dbcontext.Users.SingleOrDefaultAsync(u => u.Id == id);
        }
        public async Task UpdateAsync(User user)
        {
            _dbcontext.Update(user);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task DeleteByIdAsync(string id)
        {
            var user=await GetByIdAsync(id);
            user.Delete();
            await _dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}

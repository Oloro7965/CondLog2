using CondLog.Data;
using CondLog.Models;
using Microsoft.EntityFrameworkCore;

namespace CondLog.Repositories.Ocurrences
{
    public class OcurrenceRepository : IOcurrenceRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public OcurrenceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(Ocurrence ocurrence)
        {
            await _dbcontext.Ocurrences.AddAsync(ocurrence);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<Ocurrence>> GetAllAsync()
        {
            return await _dbcontext.Ocurrences.AsNoTracking().ToListAsync();
        }

        public async Task<Ocurrence> GetByIdAsync(Guid id)
        {
            return await _dbcontext.Ocurrences.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task UpdateAsync(Ocurrence ocurrence)
        {
            _dbcontext.Update(ocurrence);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}

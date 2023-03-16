using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class ReceiveBloodDataRepository : RepositoryBase<ReceiveBloodData>,IReceiveBloodDataRepository
    {
        private readonly ApplicationDbContext _db;

        public ReceiveBloodDataRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;

        }
        public async Task CreateRangeAsync(List<ReceiveBloodData> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        }
    }
}

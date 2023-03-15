using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class VisitRadLabTestRepository : RepositoryBase<VisitRadLabTest>, IVisitRadLabTestRepository
    {
        private readonly ApplicationDbContext _db;
        public VisitRadLabTestRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task CreateRangeAsync(List<VisitRadLabTest> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        } 
    }
}

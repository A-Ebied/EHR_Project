using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class HealthFacilityRepository : RepositoryBase<HealthFacility>, IHealthFacilityRepository
    {
        private readonly ApplicationDbContext _db;
        public HealthFacilityRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
            
        public async Task<HealthFacility> UpdateAsync(HealthFacility entity)
        {
            _db.HealthFacilities.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

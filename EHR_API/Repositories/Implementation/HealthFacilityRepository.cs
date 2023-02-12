using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class HealthFacilityRepository : RepositoryBase<HealthFacility>, IHealthFacilityRepository
    {
        public HealthFacilityRepository(ApplicationDbContext db) : base(db) { }
    }
}

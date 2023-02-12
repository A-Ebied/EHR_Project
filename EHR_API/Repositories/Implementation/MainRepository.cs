using EHR_API.Entities;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class MainRepository : IMainRepository
    {
        private ApplicationDbContext _db;

        public MainRepository(ApplicationDbContext  db)
        {
            _db = db;
            _governorate = new GovernorateRepository(_db);
            _healthFacility = new HealthFacilityRepository(_db);
        }

        public IGovernorateRepository _governorate { get; private set; }

        public IHealthFacilityRepository _healthFacility { get; private set; }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}

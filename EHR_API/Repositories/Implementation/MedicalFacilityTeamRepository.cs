using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class MedicalFacilityTeamRepository : RepositoryBase<MedicalFacilityTeam>, IMedicalFacilityTeamRepository
    {
        private readonly ApplicationDbContext _db;
        public MedicalFacilityTeamRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task CreateRangeAsync(List<MedicalFacilityTeam> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        }

    }
}

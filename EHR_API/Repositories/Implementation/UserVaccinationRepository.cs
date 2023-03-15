using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class UserVaccinationRepository : RepositoryBase<UserVaccination>, IUserVaccinationRepository
    {
        private readonly ApplicationDbContext _db;
        public UserVaccinationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task CreateRangeAsync(List<UserVaccination> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        } 
    }
}

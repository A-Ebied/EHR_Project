using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class GovernorateRepository : RepositoryBase<Governorate>, IGovernorateRepository
    {
        private readonly ApplicationDbContext _db;
        public GovernorateRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
            
        public async Task<Governorate> UpdateAsync(Governorate governorate)
        {
            _db.Governorates.Update(governorate);
            await _db.SaveChangesAsync();
            return governorate;
        }
    }
}

using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class UserInsuranceRepository : RepositoryBase<UserInsurance>, IUserInsuranceRepository
    {
        private readonly ApplicationDbContext _db;
        public UserInsuranceRepository(ApplicationDbContext db) : base(db) 
        { 
            _db= db;
        }

        public async Task CreateRangeAsync(List<UserInsurance> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        }
    }
}

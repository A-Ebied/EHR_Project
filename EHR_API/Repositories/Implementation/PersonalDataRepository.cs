using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class GovernorateRepository : RepositoryBase<Governorate>, IGovernorateRepository
    {
        public GovernorateRepository(ApplicationDbContext db) : base(db) { }
    }
}

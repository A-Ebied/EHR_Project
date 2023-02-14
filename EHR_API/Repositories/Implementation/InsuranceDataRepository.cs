using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class InsuranceDataRepository : RepositoryBase<InsuranceData>, IInsuranceDataRepository
    {
        public InsuranceDataRepository(ApplicationDbContext db) : base(db) { }
    }
}

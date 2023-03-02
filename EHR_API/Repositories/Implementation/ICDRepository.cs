using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class ICDRepository : RepositoryBase<ICD>, IICDRepository
    {
        public ICDRepository(ApplicationDbContext db) : base(db) { }
    }
}

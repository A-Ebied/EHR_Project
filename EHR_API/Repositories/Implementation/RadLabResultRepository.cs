using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class RadLabResultRepository : RepositoryBase<RadLabResult>, IRadLabResultRepository
    {
        public RadLabResultRepository(ApplicationDbContext db) : base(db) { }

    }
}

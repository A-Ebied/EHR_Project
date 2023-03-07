using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class VisitRadLabTestRepository : RepositoryBase<VisitRadLabTest>, IVisitRadLabTestRepository
    {
        public VisitRadLabTestRepository(ApplicationDbContext db) : base(db) { }
    }
}

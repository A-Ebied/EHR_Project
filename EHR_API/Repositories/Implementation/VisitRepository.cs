using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class VisitRepository : RepositoryBase<Visit>, IVisitRepository
    {
        public VisitRepository(ApplicationDbContext db) : base(db) { }
    }
}

using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class VisitVitalSignRepository : RepositoryBase<VisitVitalSign>, IVisitVitalSignRepository
    {
        public VisitVitalSignRepository(ApplicationDbContext db) : base(db) { }
    }
}

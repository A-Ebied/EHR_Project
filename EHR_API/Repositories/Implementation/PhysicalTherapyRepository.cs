using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class PhysicalTherapyRepository : RepositoryBase<PhysicalTherapy>, IPhysicalTherapyRepository
    {
        public PhysicalTherapyRepository(ApplicationDbContext db) : base(db) { }
    }
}

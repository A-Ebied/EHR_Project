using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class ContraindicationRepository : RepositoryBase<Contraindication>, IContraindicationRepository
    {
        public ContraindicationRepository(ApplicationDbContext db) : base(db) { }

    }
}

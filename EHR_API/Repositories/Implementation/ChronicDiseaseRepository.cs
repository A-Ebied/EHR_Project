using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class ChronicDiseaseRepository: RepositoryBase<ChronicDisease>, IChronicDiseaseRepository
    {
         public ChronicDiseaseRepository(ApplicationDbContext db) : base(db) { }

    }
}

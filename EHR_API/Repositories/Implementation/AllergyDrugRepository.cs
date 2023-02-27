using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class AllergyDrugRepository : RepositoryBase<AllergyDrug>, IAllergyDrugRepository
    {
        public AllergyDrugRepository(ApplicationDbContext db) : base(db) { }
    }
}

using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Repositories.Contracts
{
    public interface IAllergyDrugRepository : IRepositoryBase<AllergyDrug> 
    {
        Task CreateRangeAsync(List<AllergyDrug> entities);
    }
}

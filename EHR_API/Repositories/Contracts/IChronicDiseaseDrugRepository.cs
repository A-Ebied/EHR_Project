using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IChronicDiseaseDrugRepository:IRepositoryBase<ChronicDiseaseDrug>
    {
        Task CreateRangeAsync(List<ChronicDiseaseDrug> entities);

    }
}


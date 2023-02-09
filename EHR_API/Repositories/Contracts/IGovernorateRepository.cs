using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IGovernorateRepository : IRepositoryBase<Governorate>
    {
        Task<Governorate> UpdateAsync(Governorate governorate);
    }
}

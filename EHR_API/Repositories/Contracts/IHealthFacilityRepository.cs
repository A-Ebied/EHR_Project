using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IHealthFacilityRepository : IRepositoryBase<HealthFacility>
    {
        Task<HealthFacility> UpdateAsync(HealthFacility entity);
    }
}

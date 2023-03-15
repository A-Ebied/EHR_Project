using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IVisitVitalSignRepository : IRepositoryBase<VisitVitalSign> 
    {
        Task CreateRangeAsync(List<VisitVitalSign> entities);
    }
}

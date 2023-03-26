using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Repositories.Contracts
{
    public interface IRadLabResultImageRepository : IRepositoryBase<RadLabResultImage> 
    {
        Task CreateRangeAsync(List<RadLabResultImage> entities);
    }
}

using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IReceiveBloodDataRepository: IRepositoryBase<ReceiveBloodData>
    {
        Task CreateRangeAsync(List<ReceiveBloodData> entities);

    }

}

using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Repositories.Contracts
{
    public interface IUserInsuranceRepository : IRepositoryBase<UserInsurance> 
    {
        Task CreateRangeAsync(List<UserInsurance> entities);
    }
}

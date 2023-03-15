using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IUserVaccinationRepository : IRepositoryBase<UserVaccination> 
    { 
        Task CreateRangeAsync(List<UserVaccination> entities);
    }
}

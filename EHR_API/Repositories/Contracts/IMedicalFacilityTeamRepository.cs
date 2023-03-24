using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IMedicalFacilityTeamRepository : IRepositoryBase<MedicalFacilityTeam> 
    {
        Task CreateRangeAsync(List<MedicalFacilityTeam> entities);
    }
}

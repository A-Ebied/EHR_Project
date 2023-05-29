using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IAdmitProgressNoteRepository : IRepositoryBase<AdmitProgressNote> 
    {
        Task CreateRangeAsync(List<AdmitProgressNote> entities);
    }
}

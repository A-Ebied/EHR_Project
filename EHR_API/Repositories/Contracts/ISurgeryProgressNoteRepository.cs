using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface ISurgeryProgressNoteRepository : IRepositoryBase<SurgeryProgressNote> 
    {
        Task CreateRangeAsync(List<SurgeryProgressNote> entities);


    }
}

using EHR_API.Entities.Models;

namespace EHR_API.Repositories.Contracts
{
    public interface IVisitRadLabTestRepository : IRepositoryBase<VisitRadLabTest> 
    { 
        Task CreateRangeAsync(List<VisitRadLabTest> entities);
    }
}

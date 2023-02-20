using EHR_MVC.DTOs.GovernorateDTOs;
using System.Linq.Expressions;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IGovernorateService  
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(GovernorateCreateDTO entity);
        Task<T> UpdateAsync<T>(GovernorateUpdateDTO entity);
        Task<T> DeleteAsync<T>(int id);
    }
}

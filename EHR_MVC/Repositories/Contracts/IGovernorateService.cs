using EHR_MVC.DTOs.GovernorateDTOs;
using System.Linq.Expressions;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IGovernorateService  
    {
        Task<T> GetAllAsync<T>(string token = null);
        Task<T> GetAsync<T>(int id, string token = null);
        Task<T> CreateAsync<T>(GovernorateCreateDTO entity, string token = null);
        Task<T> UpdateAsync<T>(GovernorateUpdateDTO entity, string token = null);
        Task<T> DeleteAsync<T>(int id, string token = null);
    }
}

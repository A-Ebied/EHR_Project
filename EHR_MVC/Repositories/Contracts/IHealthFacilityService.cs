using EHR_MVC.DTOs.HealthFacilityDTOs;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IHealthFacilityService 
    {
        Task<T> GetAllAsync<T>(string token = null);
        Task<T> GetAsync<T>(int id, string token = null);
        Task<T> CreateAsync<T>(HealthFacilityCreateDTO entity, string token = null);
        Task<T> UpdateAsync<T>(HealthFacilityUpdateDTO entity, string token = null);
        Task<T> DeleteAsync<T>(int id, string token = null);
    }
}

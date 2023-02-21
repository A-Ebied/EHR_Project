using EHR_MVC.DTOs.HealthFacilityDTOs;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IHealthFacilityService 
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(HealthFacilityCreateDTO entity);
        Task<T> UpdateAsync<T>(HealthFacilityUpdateDTO entity);
        Task<T> DeleteAsync<T>(int id);
    }
}

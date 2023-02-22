using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.Repositories.Contracts;
using static EHR_MVC.Extensions.SD;

namespace EHR_MVC.Repositories.Implementation
{
    public class HealthFacilityIService : BaseService, IHealthFacilityService
    {
        //private readonly IHttpClientFactory _clientFactory;
        private string _url;

        public HealthFacilityIService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory) 
        {
            //_clientFactory = clientFactory;
            _url = configuration.GetValue<string>("URLs:EHRAPI");
        }

        public Task<T> CreateAsync<T>(HealthFacilityCreateDTO entity, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.POST,
                Data = entity,
                URL = $"{_url}/api/HealthFacilityAPI/CreateHealthFacility",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.DELETE,
                URL = $"{_url}/api/HealthFacilityAPI/{id}",
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                URL = $"{_url}/api/HealthFacilityAPI/GetHealthFacilities",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                 URL = $"{_url}/api/HealthFacilityAPI/{id}",
                 Token = token
            });
        }

        public Task<T> UpdateAsync<T>(HealthFacilityUpdateDTO entity, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = entity,
                URL = $"{_url}/api/HealthFacilityAPI/{entity.Id}",
                Token = token
            });
        }
    }
}


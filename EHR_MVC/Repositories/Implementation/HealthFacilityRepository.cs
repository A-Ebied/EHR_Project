using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.Repositories.Contracts;
using static EHR_MVC.Extensions.APIType;

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

        public Task<T> CreateAsync<T>(HealthFacilityCreateDTO entity)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.POST,
                Data = entity,
                URL = $"{_url}/api/HealthFacilityAPI/CreateHealthFacility"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.DELETE,
                URL = $"{_url}/api/HealthFacilityAPI/{id}"
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                URL = $"{_url}/api/HealthFacilityAPI/GetHealthFacilities"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                 URL = $"{_url}/api/HealthFacilityAPI/{id}"
            });
        }

        public Task<T> UpdateAsync<T>(HealthFacilityUpdateDTO entity)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = entity,
                URL = $"{_url}/api/HealthFacilityAPI/{entity.Id}"
            });
        }
    }
}


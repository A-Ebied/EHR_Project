using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.Repositories.Contracts;
using static EHR_MVC.Extensions.APIType;

namespace EHR_MVC.Repositories.Implementation
{
    public class GovernorateService : BaseService, IGovernorateService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string _url;

        public GovernorateService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory) 
        {
            _clientFactory = clientFactory;
            _url = configuration.GetValue<string>("URLs:EHRAPI");
        }

        public Task<T> CreateAsync<T>(GovernorateCreateDTO entity)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.POST,
                Data = entity,
                URL = $"{_url}/api/GovernorateAPI"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.DELETE,
                URL = $"{_url}/api/GovernorateAPI/{id}"
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                URL = $"{_url}/api/GovernorateAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                 URL = $"{_url}/api/GovernorateAPI/{id}"
            });
        }

        public Task<T> UpdateAsync<T>(GovernorateUpdateDTO entity)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = entity,
                URL = $"{_url}/api/GovernorateAPI/{entity.Id}"
            });
        }
    }
}

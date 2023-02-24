using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS;
using EHR_MVC.Repositories.Contracts;
using static EHR_MVC.Extensions.SD;

namespace EHR_MVC.Repositories.Implementation
{
    public class UserInsuranceService : BaseService, IUserInsuranceService
    {
        //private readonly IHttpClientFactory _clientFactory;
        private string _url;

        public UserInsuranceService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory) 
        {
            //_clientFactory = clientFactory;
            _url = configuration.GetValue<string>("URLs:EHRAPI");
        }

        public Task<T> CreateAsync<T>(UserInsuranceCreateDTO entity, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.POST,
                Data = entity,
                URL = $"{_url}/api/UserInsuranceAPI/CreateUserInsurance",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.DELETE,
                URL = $"{_url}/api/UserInsuranceAPI/{id}",
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                URL = $"{_url}/api/UserInsuranceAPI/GetUsersInsurances",
                Token = token
            });
        }

        public Task<T> GetUserInsurancesAsync<T>(string id, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                 URL = $"{_url}/api/UserInsuranceAPI/{id}",
                 Token = token
            });
        }
        
        public Task<T> GetInsuranceAsync<T>(int id, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                 URL = $"{_url}/api/UserInsuranceAPI/GetInsurance?id={id}",
                 Token = token
            });
        }

        public Task<T> UpdateAsync<T>(UserInsuranceUpdateDTO entity, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = entity,
                URL = $"{_url}/api/UserInsuranceAPI/{entity.Id}",
                Token = token
            });
        }
    }
}

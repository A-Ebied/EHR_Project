using EHR_MVC.Extensions;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using Newtonsoft.Json;
using System.Text;
using static EHR_MVC.Extensions.APIType;

namespace EHR_MVC.Repositories.Implementation
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }
        public IHttpClientFactory _clientFactory { get; set; }

        public BaseService(IHttpClientFactory clientFactory)
        {
            responseModel = new();
            _clientFactory = clientFactory;
        }


        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = _clientFactory.CreateClient("EHRAPI");

                var message = new HttpRequestMessage();
                message.Headers.Add("Content-Type", "application/json");
                message.RequestUri = new Uri(apiRequest.URL);
                if (apiRequest.Data != null)
                {
                    message.Content = new StringContent(
                        JsonConvert.SerializeObject(apiRequest.Data), 
                        Encoding.UTF8, 
                        "application/json");
                }

                message.Method = apiRequest.ApiType switch
                {
                    ApiType.POST => HttpMethod.Post,
                    ApiType.PUT => HttpMethod.Put,
                    ApiType.DELETE => HttpMethod.Delete,
                    _ => HttpMethod.Get,
                };

                HttpResponseMessage apiResponse = null;
                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var Response = JsonConvert.DeserializeObject<T>(apiContent);

                return Response;
            }
            catch (Exception ex)
            {
                return JsonConvert.DeserializeObject<T>(
                    JsonConvert.SerializeObject(
                        APIResponses.InternalServerError(ex)));
            }
        }
    }
}

using static EHR_MVC.Extensions.APIType;
namespace EHR_MVC.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string URL { get; set; }
        public object Data { get; set; }
    }
}

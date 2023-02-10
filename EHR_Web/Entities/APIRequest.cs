using static EHR_Web.Extensions.Utility.SD;

namespace EHR_Web.Entities
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.Get;
        public string? Url { get; set; }
        public object? Data { get; set; }
    }
}

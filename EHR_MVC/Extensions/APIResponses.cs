using EHR_MVC.Models;
using System.Net;

namespace EHR_MVC.Extensions
{
    public static class APIResponses
    {
        public static APIResponse InternalServerError(Exception ex)
        {
            APIResponse _response = new();
            _response.IsSuccess = false;
            _response.StatusCode = HttpStatusCode.InternalServerError;
            _response.Errors = new List<string> { ex.GetBaseException().ToString() };
            return _response;
        }
    }
}

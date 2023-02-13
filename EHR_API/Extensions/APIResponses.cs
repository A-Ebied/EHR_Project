using Azure;
using EHR_API.Entities;
using System.Net;

namespace EHR_API.Extensions
{
    public static class APIResponses
    {
        public static APIResponse BadRequest(string error)
        {
            APIResponse _response = new();
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.IsSuccess = false;
            _response.Result = "There are no result";
            _response.Errors = new List<string>() { error };
            return _response;
        } 
        
        public static APIResponse NotFound(string error)
        {
            APIResponse _response = new();
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.IsSuccess = false;
            _response.Result = "There are no result";
            _response.Errors = new List<string>() { error };
            return _response;
        } 
        
        public static APIResponse InternalServerError(Exception ex)
        {
            APIResponse _response = new();
            _response.IsSuccess = false;
            _response.StatusCode = HttpStatusCode.InternalServerError;
            _response.Errors = new List<string> { ex.GetBaseException().ToString() };
            return _response;
        }
        public static APIResponse Unauthorized()
        {
            APIResponse _response = new();
            _response.Errors = new() { "The Email and Password are wrong" };
            _response.IsSuccess = false;
            _response.StatusCode = HttpStatusCode.Unauthorized;
            return _response;
        }
    }
}

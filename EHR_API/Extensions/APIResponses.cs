using Azure;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
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

        public static UserDTOForOthers User(RegistrationData registrationData)
        {
            UserDTOForOthers user = new();
            user.Id = registrationData.Id;
            user.Name = registrationData.FullName;
            user.UserName = registrationData.UserName;
            if (registrationData.PersonalData != null)
            {
                user.UserImageUrl = registrationData.PersonalData.UserImageUrl;
                user.AgeGroup = registrationData.PersonalData.AgeGroup;
            }
            if (registrationData.MedicalTeam != null)
            {
                user.Specialization = registrationData.MedicalTeam.MedicalSpecialization;
            }
              
            return user;
        }   
    }
}

using AutoMapper;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Governorate, GovernorateDTO>().ReverseMap();
            CreateMap<Governorate, GovernorateDTOForOthers>().ReverseMap();
            CreateMap<Governorate, GovernorateCreateDTO>().ReverseMap();
            CreateMap<Governorate, GovernorateUpdateDTO>().ReverseMap();

            CreateMap<HealthFacility, HealthFacilityDTO>().ReverseMap();
            CreateMap<HealthFacility, HealthFacilityDTOForOthers>().ReverseMap();
            CreateMap<HealthFacility, HealthFacilityCreateDTO>().ReverseMap();
            CreateMap<HealthFacility, HealthFacilityUpdateDTO>().ReverseMap();

            CreateMap<RegistrationData, RegistrationDataCreateDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataUpdateDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataDTOForOthers>().ReverseMap();

            CreateMap<RegistrationData, LoginResponseDTO>().ReverseMap();
            CreateMap<RegistrationData, LoginResponseaDataDTO>().ReverseMap();
        }
    }
}

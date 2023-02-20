using AutoMapper;
using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_MVC.DTOs.UserDataDTOs.InsuranceDataDTOS;
using EHR_MVC.DTOs.UserDataDTOs.MedicalDataDTOS;
using EHR_MVC.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_MVC.DTOs.UserDataDTOs.PatientDTOs;
using EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs;
using EHR_MVC.DTOs.UserDataDTOs.RolesDTOs;
using EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS;
using Microsoft.AspNetCore.Identity;

namespace EHR_MVC.Models
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<GovernorateDTO, GovernorateDTOForOthers>().ReverseMap();
            CreateMap<GovernorateDTO, GovernorateCreateDTO>().ReverseMap();
            CreateMap<GovernorateDTO, GovernorateUpdateDTO>().ReverseMap();
 
            CreateMap<HealthFacilityDTO, HealthFacilityDTOForOthers>().ReverseMap();
            CreateMap<HealthFacilityDTO, HealthFacilityCreateDTO>().ReverseMap();
            CreateMap<HealthFacilityDTO, HealthFacilityUpdateDTO>().ReverseMap();

            CreateMap<RegistrationDataDTO, RegistrationDataUpdateDTO>().ReverseMap();
            CreateMap<RegistrationDataDTO, RegistrationDataCreateDTO>().ReverseMap();
            CreateMap<RegistrationDataDTO, RegistrationDataDTOForOthers>().ReverseMap();

            //CreateMap<RegistrationData, LoginResponseDTO>().ReverseMap();
            //CreateMap<RegistrationData, LoginResponseaDataDTO>().ReverseMap();

            CreateMap<PersonalDataDTO, PersonalDataCreateDTO>().ReverseMap();
            CreateMap<PersonalDataDTO, PersonalDataUpdateDTO>().ReverseMap();
            CreateMap<PersonalDataDTO, PersonalDataDTOForOthers>().ReverseMap();

            CreateMap<PatientDTO, PatientCreateDTO>().ReverseMap();
            CreateMap<PatientDTO, PatientUpdateDTO>().ReverseMap();
            CreateMap<PatientDTO, PatientDTOForOthers>().ReverseMap();

            CreateMap<MedicalTeamDTO, MedicalTeamCreateDTO>().ReverseMap();
            CreateMap<MedicalTeamDTO, MedicalTeamUpdateDTO>().ReverseMap();
            CreateMap<MedicalTeamDTO, MedicalTeamDTOForOthers>().ReverseMap();

            CreateMap<MedicalDataDTO, MedicalDataCreateDTO>().ReverseMap();
            CreateMap<MedicalDataDTO, MedicalDataUpdateDTO>().ReverseMap();
            CreateMap<MedicalDataDTO, MedicalDataDTOForOthers>().ReverseMap();

            CreateMap<InsuranceDataDTO, InsuranceDataCreateDTO>().ReverseMap();
            CreateMap<InsuranceDataDTO, InsuranceDataUpdateDTO>().ReverseMap();
            CreateMap<InsuranceDataDTO, InsuranceDataDTOForOthers>().ReverseMap();

            CreateMap<UserInsuranceDTO, UserInsuranceCreateDTO>().ReverseMap();
            CreateMap<UserInsuranceDTO, UserInsuranceUpdateDTO>().ReverseMap();
            CreateMap<UserInsuranceDTO, UserInsuranceDTOForOthers>().ReverseMap();

            CreateMap<IdentityRole, RolesDTO>().ReverseMap();
        }
    }
}

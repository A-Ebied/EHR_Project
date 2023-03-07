using AutoMapper;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.DTOs.AllergyDTOs;
using EHR_API.Entities.DTOs.BloodDonationDTOs;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.ICDDTOs;
using EHR_API.Entities.DTOs.MedicationDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.UserDataDTOs.UserRolesDTOs;
using EHR_API.Entities.DTOs.VisitMedicationDTOs;
using EHR_API.Entities.DTOs.VisitRadLabTestDTOS;
using EHR_API.Entities.DTOs.VisitVitalSignDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using Microsoft.AspNetCore.Identity;

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
            CreateMap<RegistrationDataDTO, RegistrationDataUpdateDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataDTOForOthers>().ReverseMap();

            CreateMap<RegistrationData, LoginResponseDTO>().ReverseMap();
            CreateMap<RegistrationData, LoginResponseaDataDTO>().ReverseMap();

            CreateMap<PersonalData, PersonalDataCreateDTO>().ReverseMap();
            CreateMap<PersonalData, PersonalDataUpdateDTO>().ReverseMap();
            CreateMap<PersonalData, PersonalDataDTO>().ReverseMap();
            CreateMap<PersonalData, PersonalDataDTOForOthers>().ReverseMap();
             
            CreateMap<MedicalTeam, MedicalTeamCreateDTO>().ReverseMap();
            CreateMap<MedicalTeam, MedicalTeamUpdateDTO>().ReverseMap();
            CreateMap<MedicalTeam, MedicalTeamDTO>().ReverseMap();
            CreateMap<MedicalTeam, MedicalTeamDTOForOthers>().ReverseMap();

            CreateMap<MedicalData, MedicalDataCreateDTO>().ReverseMap();
            CreateMap<MedicalData, MedicalDataUpdateDTO>().ReverseMap();
            CreateMap<MedicalData, MedicalDataDTO>().ReverseMap();
            CreateMap<MedicalData, MedicalDataDTOForOthers>().ReverseMap();
 
            CreateMap<UserInsurance, UserInsuranceCreateDTO>().ReverseMap();
            CreateMap<UserInsurance, UserInsurancesCreateDTO>().ReverseMap();
            CreateMap<UserInsurance, UserInsuranceUpdateDTO>().ReverseMap();
            CreateMap<UserInsurance, UserInsuranceDTO>().ReverseMap();
            
            CreateMap<IdentityRole, RolesDTO>().ReverseMap();

            CreateMap<Allergy, AllergyCreateDTO>().ReverseMap();
            CreateMap<Allergy, AllergyDTOForOthers>().ReverseMap();
            CreateMap<Allergy, AllergyUpdateDTO>().ReverseMap();
            CreateMap<Allergy, AllergyDTO>().ReverseMap();

            CreateMap<AllergyDrug, AllergyDrugCreateDTO>().ReverseMap();
            CreateMap<AllergyDrug, AllergyDrugUpdateDTO>().ReverseMap();
            CreateMap<AllergyDrug, AllergyDrugDTO>().ReverseMap(); 
            CreateMap<AllergyDrug, AllergyDrugDTOForOthers>().ReverseMap(); 
            
            CreateMap<Medication, MedicationCreateDTO>().ReverseMap();
            CreateMap<Medication, MedicationDTOForOthers>().ReverseMap();
            CreateMap<Medication, MedicationUpdateDTO>().ReverseMap();
            CreateMap<Medication, MedicationDTO>().ReverseMap();

            CreateMap<ICD, ICDCreateDTO>().ReverseMap();
            CreateMap<ICD, ICDUpdateDTO>().ReverseMap();
            CreateMap<ICD, ICDDTO>().ReverseMap();
            CreateMap<ICD, ICDDTOForOthers>().ReverseMap();

            CreateMap<BloodDonation, BloodDonationCreateDTO>().ReverseMap();
            CreateMap<BloodDonation, BloodDonationUpdateDTO>().ReverseMap();
            CreateMap<BloodDonation, BloodDonationDTO>().ReverseMap();
            CreateMap<BloodDonation, BloodDonationDTOForOthers>().ReverseMap();

            CreateMap<VisitVitalSign, VisitVitalSignCreateDTO>().ReverseMap();
            CreateMap<VisitVitalSign, VisitVitalSignUpdateDTO>().ReverseMap();
            CreateMap<VisitVitalSign, VisitVitalSignDTO>().ReverseMap();
            CreateMap<VisitVitalSign, VisitVitalSignDTOForOthers>().ReverseMap();

            CreateMap<VisitMedication, VisitMedicationCreateDTO>().ReverseMap();
            CreateMap<VisitMedication, VisitMedicationUpdateDTO>().ReverseMap();
            CreateMap<VisitMedication, VisitMedicationDTO>().ReverseMap();
            CreateMap<VisitMedication, VisitMedicationDTOForOthers>().ReverseMap();

            CreateMap<VisitRadLabTest, VisitRadLabTestCreateDTO>().ReverseMap();
            CreateMap<VisitRadLabTest, VisitRadLabTestUpdateDTO>().ReverseMap();
            CreateMap<VisitRadLabTest, VisitRadLabTestDTO>().ReverseMap();
            CreateMap<VisitRadLabTest, VisitRadLabTestDTOForOthers>().ReverseMap();
        }
    }
}

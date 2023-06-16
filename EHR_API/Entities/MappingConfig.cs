using AutoMapper;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.DTOs.BloodDonationDTOs;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.ICDDTOs;
using EHR_API.Entities.DTOs.MedicationDTOs;
using EHR_API.Entities.DTOs.PhysicalTherapyDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.PersonalDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.UserDataDTOs.RolesDTOs;
using EHR_API.Entities.DTOs.VisitMedicationDTOs;
using EHR_API.Entities.DTOs.VisitRadLabTestDTOs;
using EHR_API.Entities.DTOs.VisitVitalSignDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using Microsoft.AspNetCore.Identity;
using EHR_API.Entities.DTOs.AllergyDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.UserInsuranceDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs;
using EHR_API.Entities.DTOs.ChronicDiseaseDTOs;
using EHR_API.Entities.DTOs.ReceiveBloodDTOs;
using EHR_API.Entities.DTOs.SurgeryDTOs;
using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;
using EHR_API.Entities.DTOs.AdmitProgressNoteDTOs;
using EHR_API.Entities.DTOs.VisitDTOs;
using EHR_API.Entities.DTOs.AdmitDTOs;
using EHR_API.Entities.DTOs.BadHabitDTOs;
using EHR_API.Entities.DTOs.MedicalFacilityTeamDTOs;
using EHR_API.Entities.DTOs.ContraindicationDTOs;
using EHR_API.Entities.DTOs.RadLabResultDTOs;
using EHR_API.Entities.DTOs.VaccinationDTOs;
using EHR_API.Entities.DTOs.UserVaccinationDTOs;

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
            CreateMap<UserInsurance, UserInsuranceDTOForOthers>().ReverseMap();
            
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
            
            CreateMap<Visit, VisitCreateDTO>().ReverseMap();
            CreateMap<Visit, VisitUpdateDTO>().ReverseMap();
            CreateMap<Visit, VisitDTO>().ReverseMap();
            CreateMap<Visit, VisitDTOForOthers>().ReverseMap();

            CreateMap<VisitRadLabTest, VisitRadLabTestCreateDTO>().ReverseMap();
            CreateMap<VisitRadLabTest, VisitRadLabTestUpdateDTO>().ReverseMap();
            CreateMap<VisitRadLabTest, VisitRadLabTestDTO>().ReverseMap();
            CreateMap<VisitRadLabTest, VisitRadLabTestDTOForOthers>().ReverseMap();

            CreateMap<PhysicalTherapy, PhysicalTherapyCreateDTO>().ReverseMap();
            CreateMap<PhysicalTherapy, PhysicalTherapyUpdateDTO>().ReverseMap();
            CreateMap<PhysicalTherapy, PhysicalTherapyDTO>().ReverseMap();
            CreateMap<PhysicalTherapy, PhysicalTherapyDTOForOthers>().ReverseMap();

            CreateMap<ChronicDisease, ChronicDiseaseCreateDTO>().ReverseMap();
            CreateMap<ChronicDisease, ChronicDiseaseUpdateDTO>().ReverseMap();
            CreateMap<ChronicDisease, ChronicDiseaseDTO>().ReverseMap();
            CreateMap<ChronicDisease, ChronicDiseaseDTOForOthers>().ReverseMap();

            CreateMap<ChronicDiseaseDrug, ChronicDiseaseDrugCreateDTO>().ReverseMap();
            CreateMap<ChronicDiseaseDrug, ChronicDiseaseDrugUpdateDTO>().ReverseMap();
            CreateMap<ChronicDiseaseDrug, ChronicDiseaseDrugDTO>().ReverseMap();
            CreateMap<ChronicDiseaseDrug, ChronicDiseaseDrugDTOForOthers>().ReverseMap();

            CreateMap<ReceiveBlood, ReceiveBloodCreateDTO>().ReverseMap();
            CreateMap<ReceiveBlood, ReceiveBloodUpdateDTO>().ReverseMap();
            CreateMap<ReceiveBlood, ReceiveBloodDTO>().ReverseMap();
            CreateMap<ReceiveBlood, ReceiveBloodDTOForOthers>().ReverseMap();

            CreateMap<Surgery, SurgeryCreateDTO>().ReverseMap();
            CreateMap<Surgery, SurgeryUpdateDTO>().ReverseMap();
            CreateMap<Surgery, SurgeryDTO>().ReverseMap();
            CreateMap<Surgery, SurgeryDTOForOthers>().ReverseMap();

            CreateMap<SurgeryProgressNote, SurgeryProgressNoteCreateDTO>().ReverseMap();
            CreateMap<SurgeryProgressNote, SurgeryProgressNotesCreateDTO>().ReverseMap();
            CreateMap<SurgeryProgressNote, SurgeryProgressNoteUpdateDTO>().ReverseMap();
            CreateMap<SurgeryProgressNote, SurgeryProgressNoteDTO>().ReverseMap();
            CreateMap<SurgeryProgressNote, SurgeryProgressNoteDTOForOthers>().ReverseMap();

            CreateMap<Admit, AdmitCreateDTO>().ReverseMap();
            CreateMap<Admit, AdmitUpdateDTO>().ReverseMap();
            CreateMap<Admit, AdmitDTO>().ReverseMap();
            CreateMap<Admit, AdmitDTOForOthers>().ReverseMap();

            CreateMap<AdmitProgressNote, AdmitProgressNoteCreateDTO>().ReverseMap();
            CreateMap<AdmitProgressNote, AdmitProgressNotesCreateDTO>().ReverseMap();
            CreateMap<AdmitProgressNote, AdmitProgressNoteUpdateDTO>().ReverseMap();
            CreateMap<AdmitProgressNote, AdmitProgressNoteDTO>().ReverseMap();
            CreateMap<AdmitProgressNote, AdmitProgressNoteDTOForOthers>().ReverseMap();

            CreateMap<BadHabit, BadHabitCreateDTO>().ReverseMap();
            CreateMap<BadHabit, BadHabitUpdateDTO>().ReverseMap();
            CreateMap<BadHabit, BadHabitDTO>().ReverseMap();
            CreateMap<BadHabit, BadHabitDTOForOthers>().ReverseMap();

            CreateMap<MedicalFacilityTeam, MedicalFacilityTeamCreateDTO>().ReverseMap();
            CreateMap<MedicalFacilityTeam, MedicalFacilityTeamUpdateDTO>().ReverseMap();
            CreateMap<MedicalFacilityTeam, MedicalFacilityTeamDTO>().ReverseMap();
            //CreateMap<MedicalFacilityTeam, MedicalFacilityTeamDTOForOthers>().ReverseMap();

            CreateMap<Contraindication, ContraindicationCreateDTO>().ReverseMap();
            CreateMap<Contraindication, ContraindicationUpdateDTO>().ReverseMap();
            CreateMap<Contraindication, ContraindicationDTO>().ReverseMap();
            CreateMap<Contraindication, ContraindicationDTOForOthers>().ReverseMap();

            CreateMap<RadLabResult, RadLabResultCreateDTO>().ReverseMap();
            CreateMap<RadLabResult, RadLabResultUpdateDTO>().ReverseMap();
            CreateMap<RadLabResult, RadLabResultDTO>().ReverseMap();
            CreateMap<RadLabResult, RadLabResultDTOForOthers>().ReverseMap();

            CreateMap<Vaccination, VaccinationCreateDTO>().ReverseMap();
            CreateMap<Vaccination, VaccinationUpdateDTO>().ReverseMap();
            CreateMap<Vaccination, VaccinationDTO>().ReverseMap();
            CreateMap<Vaccination, VaccinationDTOForOthers>().ReverseMap();

            CreateMap<UserVaccination, UserVaccinationCreateDTO>().ReverseMap();
            CreateMap<UserVaccination, UserVaccinationsCreateDTO>().ReverseMap();
            CreateMap<UserVaccination, UserVaccinationUpdateDTO>().ReverseMap();
            CreateMap<UserVaccination, UserVaccinationDTO>().ReverseMap();
            CreateMap<UserVaccination, UserVaccinationDTOForOthers>().ReverseMap();
        }
    }
}

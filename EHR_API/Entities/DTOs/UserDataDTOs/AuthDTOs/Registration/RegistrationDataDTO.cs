using EHR_API.Entities.DTOs.UserDataDTOs.MedicalDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.PersonalDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.UserInsuranceDTOs;
using EHR_API.Entities.DTOs.BadHabitDTOs;
using EHR_API.Entities.DTOs.ContraindicationDTOs;
using EHR_API.Entities.DTOs.AllergyDTOs;
using EHR_API.Entities.DTOs.VisitDTOs;
using EHR_API.Entities.DTOs.AdmitDTOs;
using EHR_API.Entities.DTOs.BloodDonationDTOs;
using EHR_API.Entities.DTOs.ChronicDiseaseDTOs;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataDTO
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IEnumerable<string> Roles { get; set; }  
        public PersonalDataDTO PersonalData { get; set; }
        public MedicalDataDTO MedicalData { get; set; }
        public MedicalTeamDTO MedicalTeam { get; set; }

        public IEnumerable<UserInsuranceDTOForOthers> UserInsurances { get; set; }
        public ICollection<BadHabitDTOForOthers> BadHabits { get; set; }
        public ICollection<ContraindicationDTOForOthers> Contraindications { get; set; }
        public ICollection<AllergyDTOForOthers> Allergies { get; set; }
        public ICollection<VisitDTOForOthers> Visits { get; set; }
        public ICollection<AdmitDTOForOthers> Admits { get; set; }
        public ICollection<BloodDonationDTOForOthers> BloodDonations { get; set; }
        public List<ChronicDiseaseDTOForOthers> ChronicDiseases { get; set; }
    }
}

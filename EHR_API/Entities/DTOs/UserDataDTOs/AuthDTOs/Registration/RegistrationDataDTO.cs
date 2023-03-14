using EHR_API.Entities.DTOs.UserDataDTOs.MedicalDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.PersonalDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.UserInsuranceDTOs;
using System.ComponentModel;

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
        public DateTime UpdateddAt { get; set; }

        public IEnumerable<string> Roles { get; set; }  
        public PersonalDataDTOForOthers PersonalData { get; set; }
        public MedicalDataDTOForOthers MedicalData { get; set; }
        public UserInsuranceDTOForOthers UserInsurance { get; set; }
        public MedicalTeamDTOForOthers MedicalTeam { get; set; }
    }
}

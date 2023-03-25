using EHR_API.Entities.DTOs.UserDataDTOs;

namespace EHR_API.Entities.DTOs.ContraindicationDTOs
{
    public class ContraindicationDTO
    {
        public int Id { get; set; }
        public string MedicalCondition { get; set; }
        public string Contraindications { get; set; }
        public string ItsEffect { get; set; }
        public bool IsChronic { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserDTOForOthers MedicalTeam { get; set; }
        public string RegistrationDataId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.DTOs.ContraindicationDTOs
{
    public class ContraindicationCreateDTO
    {
        [Required]
        public string MedicalCondition { get; set; }
        [Required]
        public string Contraindications { get; set; }
        [Required]
        public string ItsEffect { get; set; }
        [Required]
        public bool IsChronic { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}

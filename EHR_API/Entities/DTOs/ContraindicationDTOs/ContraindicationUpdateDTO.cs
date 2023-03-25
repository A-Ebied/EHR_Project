using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ContraindicationDTOs
{
    public class ContraindicationUpdateDTO
    {
        [Required]
        public int Id { get; set; }
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

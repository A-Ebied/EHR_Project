using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class PatientUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string AgeGroup { get; set; }
        [Required]
        public bool IsSane { get; set; }
    }
}

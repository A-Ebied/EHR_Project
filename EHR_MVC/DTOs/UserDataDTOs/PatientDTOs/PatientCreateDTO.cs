using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.PatientDTOs
{
    public class PatientCreateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string AgeGroup { get; set; }
        [Required]
        public bool IsSane { get; set; }
    }
}

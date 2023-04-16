using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitDTOs
{
    public class VisitUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }
        [Required]
        public string VisitType { get; set; }
        [Required]
        public string PatientCondition { get; set; }
        [Required]
        public string ICDId { get; set; }
        [Required]
        public string InstructionDescription { get; set; }
        public string Note { get; set; }
        public IFormFile ReportImage { get; set; }
        // public double Price { get; set; }
        // public bool UnderInsurance { get; set; }
    }
}

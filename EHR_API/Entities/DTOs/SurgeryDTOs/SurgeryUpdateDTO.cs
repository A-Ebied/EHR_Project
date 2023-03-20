using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.SurgeryDTOs
{
    public class SurgeryUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Reason { get; set; }
        public string Description { get; set; }

        [Required]
        public string MedicalTeamId { get; set; }
        [Required]
        public int AdmitId { get; set; }
    }
}

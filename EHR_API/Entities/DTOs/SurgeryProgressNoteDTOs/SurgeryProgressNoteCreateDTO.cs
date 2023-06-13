using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs
{
    public class SurgeryProgressNoteCreateDTO
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public IFormFile File { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }

        [Required]
        public int SurgeryId { get; set; }
    }
}

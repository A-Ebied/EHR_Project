using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs
{
    public class SurgeryProgressNoteCreateDTO
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }

        [Required]
        public int SurgeryId { get; set; }
        public byte[] UserImage { get; set; }
        public string ImageName { get; set; }

    }
}

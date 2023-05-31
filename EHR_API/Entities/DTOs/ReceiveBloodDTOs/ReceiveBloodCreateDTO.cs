using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ReceiveBloodDTOs
{
    public class ReceiveBloodCreateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        public string ReceiveType { get; set; }
        [Required]
        public int AdmitId { get; set; }

    }
}

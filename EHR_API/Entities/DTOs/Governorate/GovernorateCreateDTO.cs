using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.Governorate
{
    public class GovernorateCreateDTO
    {
        [Required]
        [MaxLength(40)]
        public string? Title { get; set; }
    }
}

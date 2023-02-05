using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs
{
    public class GovernorateDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? Title { get; set; }
    }
}

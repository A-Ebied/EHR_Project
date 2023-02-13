using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.GovernorateDTOs
{
    public class GovernorateUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.GovernorateDTOs
{
    public class GovernorateCreateDTO
    {
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }
    }
}

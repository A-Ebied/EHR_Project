using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitVitalSignDTOs
{
    public class VisitVitalSignCreateDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public int VisitId { get; set; }

    }
}

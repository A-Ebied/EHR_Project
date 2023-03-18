using EHR_API.Entities.DTOs.ReceiveBloodDataDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ReceiveBloodDTOs
{
    public class ReceiveBloodUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int AdmitId { get; set; }
    }
}

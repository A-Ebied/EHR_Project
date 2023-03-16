using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ReceiveBloodDataDTOs
{
    public class ReceiveBloodDataCreateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string BloodGroup { get; set; }
        public string ReceiveType { get; set; }
        public int ReceiveBloodId { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.RadLabResultImageDTOs
{
    public class RadLabResultImageCreateDTO
    {     
        [Required]
        public int Id { get; set; }
        [Required]
        public int RadLabResultId { get; set; }
        //public byte[] Image { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        //[NotMapped]
        //public string ImageName { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class RadLabResultImage
    {
        [Key]
        public int Id { get; set; }
        public string ResultImageUrl { get; set; }
        public int RadLabResultId { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
         
        public RadLabResult RadLabResult { get; set; }
    }
}

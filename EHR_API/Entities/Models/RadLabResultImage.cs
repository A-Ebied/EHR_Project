using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class RadLabResultImage
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string ResultImageUrl { get; set; }
        public int RadLabResultId { get; set; }
        [NotMapped]
        public byte[] UserImage { get; set; }
        [NotMapped]
        public string ImageName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
         
        public RadLabResult RadLabResult { get; set; }
    }
}

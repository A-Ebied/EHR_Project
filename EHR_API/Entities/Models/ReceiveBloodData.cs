using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class ReceiveBloodData
    {
        [Key]
        public int Id { get; set; }
        public string BloodGroup { get; set; }
        public string ReceiveType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int ReceiveBloodId { get; set; }
        public ReceiveBlood ReceiveBlood { get; set; }
    }
}

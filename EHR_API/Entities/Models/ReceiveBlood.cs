using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class ReceiveBlood
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int AdmitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Admit Admit { get; set; }
        public ICollection<ReceiveBloodData> ReceivesBloodData { get; set; }
    }
}

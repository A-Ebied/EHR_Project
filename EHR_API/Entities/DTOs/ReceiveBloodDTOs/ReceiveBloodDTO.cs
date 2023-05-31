using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ReceiveBloodDTOs
{
    public class ReceiveBloodDTO
    {
        public int Id { get; set; }
        public int AdmitId { get; set; }
        public string BloodGroup { get; set; }
        public string ReceiveType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

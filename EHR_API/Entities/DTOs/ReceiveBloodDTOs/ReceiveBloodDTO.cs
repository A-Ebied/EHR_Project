using EHR_API.Entities.DTOs.ReceiveBloodDataDTOs;

namespace EHR_API.Entities.DTOs.ReceiveBloodDTOs
{
    public class ReceiveBloodDTO
    {
        public int Id { get; set; }
        public int AdmitId { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IEnumerable<ReceiveBloodDataDTOForOthers> ReceivesBloodData { get; set; }
    }
}

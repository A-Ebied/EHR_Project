
namespace EHR_API.Entities.DTOs.AdmitDTOs
{
    public class AdmitDTOForOthers
    {
        public int Id { get; set; }
        public DateTime AdmitAt { get; set; }
        public DateTime LeaveAt { get; set; }
        public string Reason { get; set; }
    }
}
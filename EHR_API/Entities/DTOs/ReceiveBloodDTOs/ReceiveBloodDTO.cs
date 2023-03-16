using EHR_API.Entities.DTOs.ReceiveBloodDataDTOs;

namespace EHR_API.Entities.DTOs.ReceiveBloodDTOs
{
    public class ReceiveBloodDTO
    {
        public int Id { get; set; }
        public string RegistrationDataId { get; set; }
        public int AdmitId { get; set; }
        public DateTime DateTime { get; set; }
        public IEnumerable<ReceiveBloodDataDTOForOthers> ReceivesBloodData { get; set; }


    }
}

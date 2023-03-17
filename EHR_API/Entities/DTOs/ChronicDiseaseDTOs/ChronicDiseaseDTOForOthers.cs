
using EHR_API.Entities.DTOs.ICDDTOs;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDTOs
{
    public class ChronicDiseaseDTOForOthers
    {
        public int Id { get; set; }
        //public string ICDId { get; set; }
        public ICDDTOForOthers ICD { get; set; }
        public string RegistrationDataId { get; set; }
    }
}

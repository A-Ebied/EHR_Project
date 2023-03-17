using EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs;
using EHR_API.Entities.DTOs.ICDDTOs;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDTOs
{
    public class ChronicDiseaseDTO
    {
        public int Id { get; set; }
        //public string ICDId { get; set; }
        public ICDDTOForOthers ICD { get; set; }
        public string RegistrationDataId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IEnumerable<ChronicDiseaseDrugDTOForOthers> ChronicDiseaseDrugs { get; set; }


    }
}

using EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDTOs
{
    public class ChronicDiseaseDTO
    {
        public string ICDId { get; set; }
        public string RegistrationDataId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IEnumerable<ChronicDiseaseDrugDTOForOthers> ChronicDiseaseDrugs { get; set; }


    }
}

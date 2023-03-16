using EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDTOs
{
    public class ChronicDiseaseCreateDTO
    {
        [Required]

        public string ICDId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
        public ICollection<ChronicDiseaseDrugCreateDTO> ChronicDiseaseDrugs { get; set; }



    }
}

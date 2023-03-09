using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.AllergyDrugDTOs
{
    public class AllergyDrugsCreateDTO
    {
        public List<AllergyDrugCreateDTO> AllergyDrugs { get; set; }
    }
}
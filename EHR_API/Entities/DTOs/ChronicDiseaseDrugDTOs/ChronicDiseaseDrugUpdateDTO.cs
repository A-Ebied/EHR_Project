using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs
{
    public class ChronicDiseaseDrugUpdateDTO
    {
        [Required]
        public int MedicationId { get; set; }
        [Required]
        public string ICDId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }


    }
}

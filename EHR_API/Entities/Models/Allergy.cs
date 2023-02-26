using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class Allergy
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Allergen { get; set; }
        public string Reaction { get; set; }
        public string Instruction { get; set; }
        public bool IsChronic { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string RegistrationDataId { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public ICollection<AllergyDrug> AllergyDrugs { get; set; }
    }
}

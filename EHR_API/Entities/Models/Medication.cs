using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contraindication { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        //public byte[] MedicationImage { get; set; }
        public IFormFile MedicationImage { get; set; }
        //[NotMapped]
        //public string ImageName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<AllergyDrug> AllergyDrugs { get; set; }
        public ICollection<VisitMedication> VisitMedications { get; set; }
        public ICollection<ChronicDiseaseDrug> ChronicDiseaseDrugs { get; set; }
    }
}

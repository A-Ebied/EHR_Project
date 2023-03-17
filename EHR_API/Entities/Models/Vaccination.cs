using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class Vaccination
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Route { get; set; }
        public string Reason { get; set; }
        public string Dosage { get; set; }
        public string VaccinationEffectiveness { get; set; }
        public string AgeRange { get; set; }
        public string Contraindication { get; set; }
        public string SideEffects { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}


namespace EHR_API.Entities.DTOs.VaccinationDTOs
{
    public class VaccinationDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string Route { get; set; }
        public string AgeRange { get; set; }
        public string Duration { get; set; }
        public string NumberOfTimes { get; set; }
        public string Dosage { get; set; }
        public string DosageNote { get; set; }
        public string Quantity { get; set; }
        public string Contraindication { get; set; }
        public string SideEffects { get; set; }
        public bool IsMandatory { get; set; } = false;
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

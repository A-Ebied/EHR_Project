using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class UserVaccination
    {
        [Key]
        public int Id { get; set; }
        public string Instruction { get; set; }
        public int VisitId { get; set; }
        public int VaccinationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Vaccination Vaccination { get; set; }
        public Visit Visit { get; set; }
    }
}

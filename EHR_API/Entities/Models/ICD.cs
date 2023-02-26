using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class ICD
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string Code { get; set; }
        public string DiagnosisName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Visit> Visits { get; set; }
        public ICollection<ChronicDisease> ChronicDiseases { get; set; }
    }
}

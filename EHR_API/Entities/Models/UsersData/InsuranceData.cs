using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models.UsersData
{
    public class InsuranceData
    {
        [Key]
        public string Id { get; set; }
        public bool HasGovernmentInsurance { get; set; }
        public bool HasAnotherInsurance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateddAt { get; set; } = DateTime.Now;

        public RegistrationData RegistrationData { get; set; }
    }
}

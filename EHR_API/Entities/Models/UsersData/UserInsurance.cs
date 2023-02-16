using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models.UsersData
{
    public class UserInsurance
    {
        [Key]
        public int Id { get; set; }
        public string InsuranceNo { get; set; }
        public string InsuranceOrganizationName { get; set; }
        public string RelationshipWithOrganization { get; set; }
        public string InsuranceType { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdateddAt { get; set; }

        public string InsuranceDataId { get; set; }
        public InsuranceData InsuranceData { get; set; }
    }
}

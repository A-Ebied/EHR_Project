using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class Governorate
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }

        public ICollection<HealthFacility> HealthFacilitys { get; set; }
        public ICollection<PersonalData> PersonalData { get; set; }
    }
}

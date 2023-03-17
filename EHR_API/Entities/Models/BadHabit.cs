using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class BadHabit
    {
        [Key]
        public int Id { get; set; }
        public string Habit { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string RegistrationDataId { get; set; }
        public RegistrationData RegistrationData { get; set; }
    }
}

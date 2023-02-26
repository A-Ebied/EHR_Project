using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.Models
{
    public class BadHabit
    {
        public int Id { get; set; }
        public string Habit { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string RegistrationDataId { get; set; }
        public RegistrationData RegistrationData { get; set; }
    }
}

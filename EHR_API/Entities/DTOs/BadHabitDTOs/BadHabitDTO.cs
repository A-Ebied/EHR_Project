using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.BadHabitDTOs
{
    public class BadHabitDTO
    {
        public int Id { get; set; }
        public string Habit { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string RegistrationDataId { get; set; }
    }
}

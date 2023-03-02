using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.BadHabitDTOs
{
    public class BadHabitCreateDTO
    {
        [Required]
        public string Habit { get; set; }
        public string Notes { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}

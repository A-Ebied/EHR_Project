using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.BadHabitDTOs
{
    public class BadHabitUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Habit { get; set; }
        public string Notes { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}

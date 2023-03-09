using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserVaccinationDTOs
{
    public class UserVaccinationUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Instruction { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
        [Required]
        public int VisitId { get; set; }
        [Required]
        public string VaccinationId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.DTOs.UserVaccinationDTOs
{
    public class UserVaccinationCreateDTO
    {
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

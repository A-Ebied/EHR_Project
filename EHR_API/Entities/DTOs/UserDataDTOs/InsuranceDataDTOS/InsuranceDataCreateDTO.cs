using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class InsuranceDataCreateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public bool HasGovernmentInsurance { get; set; }
        [Required]
        public bool HasAnotherInsurance { get; set; }
    }
}

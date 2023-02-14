using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class InsuranceDataUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public bool HasGovernmentInsurance { get; set; }
        [Required]
        public bool HasAnotherInsurance { get; set; }
    }
}

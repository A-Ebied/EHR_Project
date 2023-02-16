using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class UserInsurancesCreateDTO
    {
        public ICollection<UserInsuranceCreateDTO> _userInsurances { get; set; }
    }
}

using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataDTOForOthers
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        public string UserName { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
    }
}

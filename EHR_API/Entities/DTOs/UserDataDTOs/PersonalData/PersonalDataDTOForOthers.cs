namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class PersonalDataDTOForOthers
    {
        public string Id { get; set; }
        public string IdType { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        public string UserName { get; init; }
        public string Password { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
    }
}

using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs.PersonalDataDTOs
{
    public class PersonalDataDTO
    {
        public string Id { get; set; }
        public string UserImageUrl { get; set; }
        public string Occupation { get; set; }
        public int NumOfChildren { get; set; }
        public DateTime BirthDate { get; set; }
        public int GovernorateId { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string EmergencyPhone1 { get; set; }
        public string EmergencyPhone2 { get; set; }
        public string Gender { get; set; }
        public string AgeGroup { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

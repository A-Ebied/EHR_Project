using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class PersonalDataDTOForOthers
    {
        public string Id { get; set; }
        public string UserImageUrl { get; set; }
        public string Occupation { get; set; }
        public DateTime BirthDate { get; set; }
        public int GovernorateId { get; set; }
        public string Phone1 { get; set; }
        public string EmergencyPhone1 { get; set; }
        public string Gender { get; set; }
    }
}

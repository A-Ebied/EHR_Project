using System.ComponentModel;

namespace EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs
{
    public class PersonalDataDTOForOthers
    {
        public string Id { get; set; }
        public string UserImageUrl { get; set; }
        public string Occupation { get; set; }
        [DisplayName("Number Of Children")]
        public DateTime BirthDate { get; set; }
        public int GovernorateId { get; set; }
        public string Phone1 { get; set; }
        [DisplayName("Emergency Phone_1")]
        public string EmergencyPhone1 { get; set; }
        [DisplayName("Emergency Phone_2")]
        public string Gender { get; set; }
    }
}

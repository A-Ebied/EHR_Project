using System.ComponentModel;

namespace EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs
{
    public class PersonalDataDTO
    {
        public string Id { get; set; }
        public string UserImageUrl { get; set; }
        public string Occupation { get; set; }
        [DisplayName("Number Of Children")]
        public int NumOfChildren { get; set; }
        public DateTime BirthDate { get; set; }
        public int GovernorateId { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        [DisplayName("Emergency Phone_1")]
        public string EmergencyPhone1 { get; set; }
        [DisplayName("Emergency Phone_2")]
        public string EmergencyPhone2 { get; set; }
        public string Gender { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }
    }
}

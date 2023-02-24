using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs
{
    public class PersonalDataCreateDTO
    {
        [Required]
        public string Id { get; set; }
        public byte[] UserImage { get; set; }
        public string ImageName { get; set; }
        public string Occupation { get; set; }
        public int NumOfChildren { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int GovernorateId { get; set; }
        public string Address { get; set; }
        [MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string Phone1 { get; set; }
        [Required]
        [MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string EmergencyPhone1 { get; set; }
        [MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string EmergencyPhone2 { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}

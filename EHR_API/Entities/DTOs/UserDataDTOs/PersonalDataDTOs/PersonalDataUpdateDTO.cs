using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.PersonalDataDTOs
{
    public class PersonalDataUpdateDTO
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
        public string Phone1 { get; set; }
        [Required]
        public string EmergencyPhone1 { get; set; }
        public string EmergencyPhone2 { get; set; }
        [Required]
        public string Gender { get; set; }
        public string AgeGroup { get; set; }
    }
}

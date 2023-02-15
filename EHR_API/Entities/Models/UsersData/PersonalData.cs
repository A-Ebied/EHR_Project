using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models.UsersData
{
    public class PersonalData
    {
        [Key]
        public string Id { get; set; }
        public string UserImageUrl { get; set; }
        public string IdImageUrl { get; set; }
        [NotMapped]
        public IFormFile UserImage { get; set; }
        [NotMapped]
        public IFormFile IdImage { get; set; }
        public string Occupation { get; set; } // مهنة
        public int NumOfChildren { get; set; }
        public DateTime BirthDate { get; set; }
        public int GovernorateId { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string EmergencyPhone1 { get; set; }
        public string EmergencyPhone2 { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateddAt { get; set; } = DateTime.Now;

        public RegistrationData RegistrationData { get; set; }
        public Governorate Governorate { get; set; }
    }
}

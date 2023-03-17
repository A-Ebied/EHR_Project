using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class SurgeryProgressNote
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string MedicalTeamId { get; set; }
        public int SurgeryId { get; set; }
        [NotMapped]
        public byte[] UserImage { get; set; }
        [NotMapped]
        public string ImageName { get; set; }
      
        public MedicalTeam MedicalTeam { get; set; }
        public Surgery Surgery { get; set; }
    }
}

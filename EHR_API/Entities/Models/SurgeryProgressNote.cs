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
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public string MedicalTeamId { get; set; }
        public int SurgeryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public MedicalTeam MedicalTeam { get; set; }
        public Surgery Surgery { get; set; }
    }
}

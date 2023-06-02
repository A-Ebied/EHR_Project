using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class RadLabResult
    {
        [Key]
        public int Id { get; set; }
        public string ResultNote { get; set; }
        public string ImageUrl { get; set; }
        public string FileUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public int VisitRadLabTestId { get; set; }
        public int HealthFacilityId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
         
        public VisitRadLabTest VisitRadLabTest { get; set; }
        public HealthFacility HealthFacility { get; set; }

        public string MedicalTeamId { get; set; }
        public MedicalTeam MedicalTeam { get; set; }
    }
}

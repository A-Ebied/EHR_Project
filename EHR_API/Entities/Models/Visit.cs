using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public string RegistrationDataId { get; set; }
        public string MedicalTeamId { get; set; }
        public int HealthFacilityId { get; set; }
        public string VisitType { get; set; }
        public string PatientCondition { get; set; }
        public string ICDId { get; set; }
        public string InstructionDescription { get; set; }
        public string Note { get; set; }
        public string ReportImageUrl { get; set; }
        [NotMapped]
        public IFormFile ReportImage { get; set; }
         
       // public double Price { get; set; }
       // public bool UnderInsurance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICD  ICD { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public MedicalTeam MedicalTeam { get; set; }
        public HealthFacility HealthFacility { get; set; }

        public ICollection<VisitVitalSign> VisitVitalSigns { get; set; }
        public ICollection<VisitMedication> VisitMedications { get; set; }
        public ICollection<VisitRadLabTest> VisitRadLabTests { get; set; }
        public ICollection<PhysicalTherapy> PhysicalTherapies { get; set; }
        public ICollection<UserVaccination> UserVaccinations { get; set; }
    }
}

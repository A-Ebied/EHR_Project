using System.ComponentModel.DataAnnotations;
using EHR_API.Entities.DTOs.VisitVitalSignDTOs;
using EHR_API.Entities.DTOs.VisitMedicationDTOs;
using EHR_API.Entities.DTOs.VisitRadLabTestDTOS;
using EHR_API.Entities.DTOs.PhysicalTherapyDTOs;
using EHR_API.Entities.DTOs.UserVaccinationDTOs;

namespace EHR_API.Entities.DTOs.VisitDTOs
{
    public class VisitCreateDTO
    {
        [Required]
        public string RegistrationDataId { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }
        [Required]
        public string VisitType { get; set; }
        [Required]
        public string PatientCondition { get; set; }
        [Required]
        public string ICDId { get; set; }
        [Required]
        public string InstructionDescription { get; set; }
        public string Note { get; set; }
        public byte[] ReportImage { get; set; }
        public string ImageName { get; set; }
        // public double Price { get; set; }
        // public bool UnderInsurance { get; set; }
        public bool IsAdmit { get; set; }
        
        public ICollection<VisitVitalSignCreateDTO> VisitVitalSigns { get; set; }
        public ICollection<VisitMedicationCreateDTO> VisitMedications { get; set; }
        public ICollection<VisitRadLabTestCreateDTO> VisitRadLabTests { get; set; }
        public ICollection<PhysicalTherapyCreateDTO> PhysicalTherapies { get; set; }
        public ICollection<UserVaccinationCreateDTO> UserVaccinations { get; set; }
    }
}

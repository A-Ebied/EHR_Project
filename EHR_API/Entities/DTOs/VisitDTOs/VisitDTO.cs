using EHR_API.Entities.DTOs.PhysicalTherapyDTOs;
using EHR_API.Entities.DTOs.UserVaccinationDTOs;
using EHR_API.Entities.DTOs.VisitMedicationDTOs;
using EHR_API.Entities.DTOs.VisitRadLabTestDTOS;
using EHR_API.Entities.DTOs.VisitVitalSignDTOs;

namespace EHR_API.Entities.DTOs.VisitDTOs
{
    public class VisitDTO
    {
        public int Id { get; set; }
        public string RegistrationDataId { get; set; }
        public string MedicalTeamId { get; set; }
        public int HealthFacilityId { get; set; }
        public string VisitType { get; set; }
        public string PatientCondition { get; set; }
        public string ICDId { get; set; }
        public string InstructionDescription { get; set; }
        public string Note { get; set; }
        public byte[] ReportImage { get; set; }
        public string ImageName { get; set; }
        // public double Price { get; set; }
        // public bool UnderInsurance { get; set; }
        public bool IsAdmit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateddAt { get; set; }
        public ICollection<VisitVitalSignDTOForOthers> VisitVitalSigns { get; set; }
        public ICollection<VisitMedicationDTOForOthers> VisitMedications { get; set; }
        public ICollection<VisitRadLabTestDTOForOthers> VisitRadLabTests { get; set; }
        public ICollection<PhysicalTherapyDTOForOthers> PhysicalTherapies { get; set; }
        public ICollection<UserVaccinationDTOForOthers> UserVaccinations { get; set; }
    }
}

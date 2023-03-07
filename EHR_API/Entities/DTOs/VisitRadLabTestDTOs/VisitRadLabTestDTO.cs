using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.DTOs.MedicationDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitRadLabTestDTOS
{
    public class VisitRadLabTestDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string TestType { get; set; }
        public string Description { get; set; }
        public int VisitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //public ICollection<RadLabResult> VisitRadiologyResults { get; set; }
    }
}

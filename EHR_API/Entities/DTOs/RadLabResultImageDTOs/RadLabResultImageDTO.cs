using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.ReceiveBloodDataDTOs;
using EHR_API.Entities.DTOs.SurgeryDTOs;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.DTOs.RadLabResultImageDTOs
{
    public class RadLabResultImageDTO
    {
        public int Id { get; set; }
        public string ResultImageUrl { get; set; }
        public int RadLabResultId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
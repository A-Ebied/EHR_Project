using EHR_API.Entities.DTOs.ReceiveBloodDataDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ReceiveBloodDTOs
{
    public class ReceiveBloodCreateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string RegistrationDataId { get; set; }

        [Required]
        public int AdmitId { get; set; }
        public ICollection<ReceiveBloodDataCreateDTO> ReceivesBloodData { get; set; }


    }
}

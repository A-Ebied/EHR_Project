using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ReceiveBloodDTOs
{
    public class ReceiveBloodUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string RegistrationDataId { get; set; }

        [Required]
        public int AdmitId { get; set; }


    }
}

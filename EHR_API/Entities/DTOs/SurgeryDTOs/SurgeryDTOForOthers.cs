using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.DTOs.SurgeryDTOs
{
    public class SurgeryDTOForOthers
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string MedicalTeamId { get; set; }
        public int AdmitId { get; set; }

        //public double Price { get; set; }
        //public bool UnderInsurance { get; set; }


    }
}

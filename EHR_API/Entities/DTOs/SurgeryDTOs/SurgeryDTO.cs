using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.DTOs.SurgeryDTOs
{
    public class SurgeryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string MedicalTeamId { get; set; }
        public int AdmitId { get; set; }

        public IEnumerable<SurgeryProgressNoteDTOForOthers> SurgeryProgressNotes { get; set; }


    }
}

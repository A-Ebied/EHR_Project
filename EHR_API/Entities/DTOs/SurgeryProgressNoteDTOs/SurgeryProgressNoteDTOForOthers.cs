
using EHR_API.Entities.DTOs.MedicationDTOs;

namespace EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs
{
    public class SurgeryProgressNoteDTOForOthers
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public string MedicalTeamId { get; set; }
        public int SurgeryId { get; set; }

      // public MedicalTeamDTOForOthers MedicalTeam { get; set; }
      // public SurgeryDTOForOthers Surgery { get; set; } 
    }
}

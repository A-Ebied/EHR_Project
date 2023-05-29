using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;

namespace EHR_API.Entities.DTOs.AdmitProgressNoteDTOs
{
    public class AdmitProgressNotesCreateDTO
    {
        public List<SurgeryProgressNoteCreateDTO> SurgeryProgressNotes { get; set; }
    }
}

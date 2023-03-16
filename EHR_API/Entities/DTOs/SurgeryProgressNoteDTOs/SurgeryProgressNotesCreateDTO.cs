using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;

namespace EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs
{
    public class SurgeryProgressNotesCreateDTO
    {
        public List<SurgeryProgressNoteCreateDTO> SurgeryProgressNotes { get; set; }
    }
}

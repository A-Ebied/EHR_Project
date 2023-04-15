namespace EHR_API.Entities.DTOs.UserVaccinationDTOs
{
    public class UserVaccinationDTO
    {
        public int Id { get; set; }
        public string Instruction { get; set; }
        public int VisitId { get; set; }
        public int VaccinationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

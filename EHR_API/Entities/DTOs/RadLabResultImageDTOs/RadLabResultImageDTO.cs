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
namespace EHR_API.Entities.Models.GeneralData
{
    public class Governorate
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

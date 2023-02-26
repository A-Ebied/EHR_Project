using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.Models
{
    public class ReceiveBlood
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string RegistrationDataId { get; set; }
        public int AdmitId { get; set; }

        public Admit Admit { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public ICollection<ReceiveBloodData> ReceivesBloodData { get; set; }
    }
}

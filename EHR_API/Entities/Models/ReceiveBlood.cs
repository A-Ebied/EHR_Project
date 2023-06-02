using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class ReceiveBlood
    {
        [Key]
        public int Id { get; set; }
        public string BloodGroup { get; set; }
        public string ReceiveType { get; set; }
        public int AdmitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Admit Admit { get; set; }
        public string MedicalTeamId { get; set; }
        public MedicalTeam MedicalTeam { get; set; }

    }
}

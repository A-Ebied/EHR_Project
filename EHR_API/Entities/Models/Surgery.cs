using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class Surgery
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string MedicalTeamId { get; set; }
        [ForeignKey("Admit")]
        public int AdmitId { get; set; }
        //public double Price { get; set; }
        //public bool UnderInsurance { get; set; }

        public MedicalTeam MedicalTeam { get; set; }
        public Admit Admit { get; set; }
        public ICollection<SurgeryProgressNote> SurgeryProgressNotes { get; set; }

    }
}

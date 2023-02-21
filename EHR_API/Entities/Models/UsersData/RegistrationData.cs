using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models.UsersData
{
    public class RegistrationData : IdentityUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override string Id { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        // email
        // password
        // UserName
        // PhoneNumber
        // Roles
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdateddAt { get; set; }


        public PersonalData PersonalData { get; set; }
        public MedicalData MedicalData { get; set; }
        public InsuranceData InsuranceData { get; set; }
        public Patient Patient { get; set; }
        public MedicalTeam MedicalTeam { get; set; }
        public HealthFacility HealthFacility { get; set; }


        //public ICollection<UserInsurance> PatientInsurances { get; set; }
        //public ICollection<UserBadHabit> BadHabits { get; set; }
        //public ICollection<Contraindication> Contraindications { get; set; }
        //public ICollection<Allergy> Allergies { get; set; }
        //public ICollection<Visit> Visits { get; set; }
        //public ICollection<BloodDonation> BloodDonations { get; set; }
        //public ICollection<ReceiveBlood> ReceiveBloods { get; set; }
    }
}

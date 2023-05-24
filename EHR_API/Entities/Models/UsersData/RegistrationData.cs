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
        public string ConfirmEmailCode { get; set; }
        public string ForgotPasswordCode { get; set; }
        // email
        // password
        // UserName
        // PhoneNumber
        // Roles
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdateddAt { get; set; }


        public PersonalData PersonalData { get; set; }
        public MedicalData MedicalData { get; set; }
        public MedicalTeam MedicalTeam { get; set; }

        public ICollection<HealthFacility> HealthFacilities { get; set; }
        public ICollection<UserInsurance> UserInsurances { get; set; }
        public ICollection<BadHabit> BadHabits { get; set; }
        public ICollection<Contraindication> Contraindications { get; set; }
        public ICollection<Allergy> Allergies { get; set; }
        public ICollection<Visit> Visits { get; set; }
        public ICollection<BloodDonation> BloodDonations { get; set; }
        public ICollection<ReceiveBlood> ReceiveBloods { get; set; }
    }
}

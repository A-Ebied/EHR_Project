using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models.UsersData
{
    public class RegistrationData : IdentityUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override string Id { get; set; }
        public string IdType { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateddAt { get; set; } = DateTime.Now;
    }
}

﻿using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.Models
{
    public class HealthFacility
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string SubordinateTo { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }

        public string RegistrationDataId { get; set; }
        public int GovernorateId { get; set; }

        public Governorate Governorate { get; set; }
        public RegistrationData RegistrationData { get; set; }
        //public ICollection<MedicalFacilityTeam> MedicalFacilityTeams { get; set; }
        //public ICollection<Visit> Visits { get; set; }
    }
}

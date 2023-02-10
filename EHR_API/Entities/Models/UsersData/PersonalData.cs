﻿namespace EHR_API.Entities.Models.UsersData
{
    public class PersonalData
    {
        public string Id { get; set; }
        public string UserImageUrl { get; set; }
        public string IdImageUrl { get; set; }
        public string Occupation { get; set; } // مهنة
        public int NumOfChildren { get; set; }
        public DateTime BirthDate { get; set; }
        public int GovernorateId { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string EmergencyPhone1 { get; set; }
        public string EmergencyPhone2 { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string FamilyHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string DNAImageResultUrl { get; set; }
        public bool HasGovernmentInsurance { get; set; }
        public bool HasAnotherInsurance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateddAt { get; set; } = DateTime.Now;

        public Governorate Governorate { get; set; }
    }
}
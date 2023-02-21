﻿using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataDTO
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }

        public IEnumerable<string> Roles { get; set; }  
        public PersonalDataDTOForOthers PersonalData { get; set; }
        public InsuranceDataDTOForOthers InsuranceData { get; set; }
        public MedicalDataDTOForOthers MedicalData { get; set; }
        public MedicalTeamDTOForOthers MedicalTeam { get; set; }
        public PatientDTOForOthers Patient { get; set; }
    }
}

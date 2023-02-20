﻿
using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS
{
    public class UserInsuranceUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string InsuranceNo { get; set; }
        [Required]
        public string InsuranceOrganizationName { get; set; }
        [Required]
        public string RelationshipWithOrganization { get; set; }
        [Required]
        public string InsuranceType { get; set; }
        [Required]
        public string InsuranceDataId { get; set; }
    }
}

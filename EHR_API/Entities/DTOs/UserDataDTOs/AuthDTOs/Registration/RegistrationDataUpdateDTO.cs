﻿using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //[Required]
        //public ICollection<string> Roles { get; init; }
        [Required]
        public string Role { get; set; }
    }
}

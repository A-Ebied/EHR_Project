﻿using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserVaccinationDTOs
{
    public class UserVaccinationCreateDTO
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Instruction { get; set; }
        [Required]
        public int VisitId { get; set; }
        [Required]
        public int VaccinationId { get; set; }
    }
}

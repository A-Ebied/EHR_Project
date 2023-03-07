using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitRadLabTestDTOS
{
    public class VisitRadLabTestDTOForOthers
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string TestType { get; set; }
    }
}

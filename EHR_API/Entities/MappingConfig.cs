using AutoMapper;
using EHR_API.Entities.DTOs.Governorate;
using EHR_API.Entities.Models;

namespace EHR_API.Entities
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Governorate, GovernorateDTO>().ReverseMap();
            CreateMap<Governorate, GovernorateCreateDTO>().ReverseMap();
            CreateMap<Governorate, GovernorateUpdateDTO>().ReverseMap();
        }
    }
}

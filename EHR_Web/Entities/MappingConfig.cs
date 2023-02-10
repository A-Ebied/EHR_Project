using AutoMapper;
using EHR_Web.Entities.DTOs.GovernorateDTOs;
using EHR_Web.Entities.DTOs.HealthFacilityDTOs;

namespace EHR_Web.Entities
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<GovernorateDTO, GovernorateCreateDTO>().ReverseMap();
            CreateMap<GovernorateDTO, GovernorateUpdateDTO>().ReverseMap();
            
            CreateMap<HealthFacilityDTO, HealthFacilityCreateDTO>().ReverseMap();
            CreateMap<HealthFacilityDTO, HealthFacilityUpdateDTO>().ReverseMap();

        }
    }
}

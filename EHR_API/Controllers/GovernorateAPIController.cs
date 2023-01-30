using EHR_API.Entities.DTOs;
using EHR_API.Extensions.DataStore;
using Microsoft.AspNetCore.Mvc;

namespace EHR_API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/GovernorateAPI")]
    [ApiController]
    public class GovernorateController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<GovernorateDTO> GetGovernorates() 
        {
            return GovernorateStore.governorateList;
        }

        [HttpGet("{id:int}")]
        public GovernorateDTO? GetGovernorate(int id)
        {
            return GovernorateStore.governorateList.FirstOrDefault(g => g.Id == id);
        }
    }
}

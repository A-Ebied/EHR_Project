using EHR_API.Entities.DTOs;
using EHR_API.Extensions.DataStore;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EHR_API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/GovernorateAPI")]
    [ApiController]
    public class GovernorateController : ControllerBase
    {
        [HttpGet]
        //[ProducesResponseType(200, Type = typeof(IEnumerable<GovernorateDTO>) )]
        //[ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<GovernorateDTO>> GetGovernorates() 
        {
            var governorates = GovernorateStore.governorateList;
            if (governorates == null)
            {
                return NotFound();
            }

            return Ok(governorates);
        }

        [HttpGet("{id:int}", Name = "GetGovernorate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<GovernorateDTO?> GetGovernorate(int id)
        {
            if (id == 0) 
            { 
                return BadRequest();
            }

            var governorate = GovernorateStore.governorateList.FirstOrDefault(g => g.Id == id);
            if (governorate == null)
            {
                return NotFound(id);
            }

            return Ok(governorate);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<GovernorateDTO> CreateGovernorate([FromBody] GovernorateDTO governorate) 
        {
            if (governorate == null)
            {
                return BadRequest(governorate);
            }

            if (GovernorateStore.governorateList.FirstOrDefault(g => g.Title!.ToLower() == governorate.Title!.ToLower()) != null)
            {
                ModelState.AddModelError("Create Governorate Error", "Governorate is already exists !");
                return BadRequest(ModelState);
            }

            if (governorate.Id != 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            governorate.Id = GovernorateStore.governorateList.OrderByDescending(g => g.Id).FirstOrDefault().Id + 1;
            GovernorateStore.governorateList.Add(governorate);

            // للعنصر الذي تم انشاءه response في url بيدي 
           return CreatedAtRoute("GetGovernorate", new { id = governorate.Id }, governorate);
        }
        
        [HttpDelete("{id:int}", Name = "DeleteGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteGovernorate(int id) 
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var removedGoveern = GovernorateStore.governorateList.FirstOrDefault(g => g.Id == id);
            if (removedGoveern == null) 
            {
                return NotFound();
            }

            GovernorateStore.governorateList.Remove(removedGoveern);
            return NoContent();
        }


        [HttpPut("{id:int}", Name = "UpdateGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateGovernorate(int id, [FromBody] GovernorateDTO governorate)
        {
            if (id != governorate.Id || governorate ==null)
            {
                return BadRequest();
            }

            var updatedGoveern = GovernorateStore.governorateList.FirstOrDefault(g => g.Id == id);
            if (updatedGoveern == null)
            {
                return NotFound();
            }

           // update
            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "PatchGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult PatchGovernorate(int id, JsonPatchDocument<GovernorateDTO> governoratePatch)
        {
            if (id == 0 || governoratePatch == null)
            {
                return BadRequest(governoratePatch);
            }

            var governorate = GovernorateStore.governorateList.FirstOrDefault(g => g.Id == id);
            if (governorate == null)
            {
                return NotFound(governoratePatch);
            }

            governoratePatch.ApplyTo(governorate, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}

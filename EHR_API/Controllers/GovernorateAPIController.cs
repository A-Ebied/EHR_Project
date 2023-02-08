using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.Governorate;
using EHR_API.Entities.Models;
using EHR_API.Extensions.DataStore;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/GovernorateAPI")]
    [ApiController]
    public class GovernorateController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public GovernorateController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        //[ProducesResponseType(200, Type = typeof(IEnumerable<GovernorateDTO>) )]
        //[ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<GovernorateDTO>>> GetGovernorates() 
        {
            var governorates = await _db.Governorates.ToListAsync();
            if (governorates.Count == 0)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<GovernorateDTO>>(governorates));
        }

        [HttpGet("{id:int}", Name = "GetGovernorate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GovernorateDTO?>> GetGovernorate(int id)
        {
            if (id < 1) 
            { 
                return BadRequest();
            }

            var governorate = await _db.Governorates.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (governorate == null)
            {
                return NotFound(id);
            }

            return Ok(_mapper.Map<GovernorateDTO>(governorate));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GovernorateDTO>> CreateGovernorate([FromBody] GovernorateCreateDTO governorateDTO) 
        {
            if (governorateDTO == null)
            {
                return BadRequest(governorateDTO);
            }

            if (await _db.Governorates.FirstOrDefaultAsync(g => g.Title!.ToLower() == governorateDTO.Title!.ToLower()) != null)
            {
                ModelState.AddModelError("Create Governorate Error", "Governorate is already exists !");

                return BadRequest(ModelState);
            }

            var governorate = _mapper.Map<Governorate>(governorateDTO);
            await _db.Governorates.AddAsync(governorate);
            await _db.SaveChangesAsync();

            // للعنصر الذي تم انشاءه response في url بيدي 
            return CreatedAtRoute("GetGovernorate", new { id = governorate.Id }, governorate);
        }
        
        [HttpDelete("{id:int}", Name = "DeleteGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteGovernorate(int id) 
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var removedGoveern = await _db.Governorates.FirstOrDefaultAsync(g => g.Id == id);
            if (removedGoveern == null) 
            {
                return NotFound();
            }

            _db.Governorates.Remove(removedGoveern);
           await _db.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut("{id:int}", Name = "UpdateGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateGovernorate(int id, [FromBody] GovernorateUpdateDTO governorateDTO)
        {
            if (id != governorateDTO.Id || governorateDTO == null)
            {
                return BadRequest();
            }

            if (await _db.Governorates.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id) == null)
            {
                return NotFound();
            }

            var governorate = _mapper.Map<Governorate>(governorateDTO);
            _db.Governorates.Update(governorate);
            await _db.SaveChangesAsync();
            
            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "PatchGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> PatchGovernorate(int id, JsonPatchDocument<GovernorateUpdateDTO> governoratePatch)
        {
            if (id == 0 || governoratePatch == null)
            {
                return BadRequest(governoratePatch);
            }

            var governorate = await _db.Governorates.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (governorate == null)
            {
                return NotFound(governoratePatch);
            }

            var patch = _mapper.Map<GovernorateUpdateDTO>(governorate);
            governoratePatch.ApplyTo(patch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            governorate = _mapper.Map<Governorate>(patch);
            _db.Governorates.Update(governorate);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}

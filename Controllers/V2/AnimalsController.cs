using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Farm.Data;
using API_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Farm.Controllers.V2
{
    [ApiController]
    [Route("api/v2/[controller]")]
    [ApiExplorerSettings(GroupName = "v2")]
    public class AnimalsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AnimalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Retrieves all animals",
            Description = "Gets a list of all animals in the database."
        )]
        [SwaggerResponse(200, "Returns a list of animals.", typeof(IEnumerable<Animal>))]
        [SwaggerResponse(204, "No animals found in the database.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAnimals()
        {
            var animals = await _context.Animals.Include(p => p.AnimalType).ToListAsync();

            if (animals == null || !animals.Any())
            {
                return NoContent();
            }

            return Ok(animals);
        }
    }
}
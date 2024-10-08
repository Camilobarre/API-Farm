using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using API_Farm.Data;
using API_Farm.Models;

namespace API_Farm.Controllers.V2.AnimalTypes
{
    [ApiController]
    [Route("api/V2/[controller]")]
    [ApiExplorerSettings(GroupName = "v2")]
    public class AnimalTypesController : ControllerBase
    {
        private readonly ApplicationDbContext Context;

        public AnimalTypesController(ApplicationDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Retrieves all animal types",
            Description = "Gets a list of all animal types in the database."
        )]
        [SwaggerResponse(200, "Returns a list of animal types.", typeof(IEnumerable<AnimalType>))]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> GetAll()
        {
            var animalTypes = await Context.AnimalTypes.ToListAsync();
            if (animalTypes.Any() == false)
            {
                return NoContent();
            }
            return Ok(animalTypes);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieves a specific animal type by id",
            Description = "Gets an animal type by its unique identifier."
        )]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var animalType = await Context.AnimalTypes.FindAsync(id);
            if (animalType == null)
            {
                return NoContent();
            }
            return Ok(animalType);
        }

    }
}
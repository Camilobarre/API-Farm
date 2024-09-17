using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Farm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Farm.Controllers.V1.AnimalTypes
{
    [Route("api/V1/[controller]")]
    [ApiController]
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
    [SwaggerResponse(200, "Returns a list of animal types.", typeof(IEnumerable<animalTypes>))]
    [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult> GetAll()
        {
            var animalTypes = await Context.AnimalTypes.ToListAsync();
            if (animalTypes.Any() == false)
            {
                return NoContent();
            }
            return Ok(animalTypes);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Farm.Data;
using API_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Farm.Controllers.V1.AnimalTypes
{
    [Route("api/V1/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
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

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AnimalType nuevoAnimalType)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            Context.AnimalTypes.Add(nuevoAnimalType);
            await Context.SaveChangesAsync();
            return Ok("Se creo un nuevo tipo de animal");
        }

        [HttpGet("search/{keyword}")]
        public async Task<IActionResult> SearchByKeyword([FromRoute] string keyword)
        {
            var animalTypes = await Context.AnimalTypes.Where(
                p => p.Name.Contains(keyword) ||
                p.Description.Contains(keyword)).ToListAsync();
            if (animalTypes.Any() == false)
            {
                return NoContent();
            }
            return Ok(animalTypes);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] AnimalType updatedAnimalType)
        {
            var animalType = CheckExistence(id);
            if (animalType == false)
            {
                return NoContent();
            }

            updatedAnimalType.Id = id;
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            Context.Entry(updatedAnimalType).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return Ok("Se actualizó el tipo de animal");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var animalType = CheckExistence(id);
            if (animalType == false)
            {
                return NoContent();
            }

            Context.AnimalTypes.Remove(await Context.AnimalTypes.FindAsync(id));
            await Context.SaveChangesAsync();
            return Ok("Se eliminó el tipo de animal");
        }

        private bool CheckExistence(int id)
        {
            return Context.AnimalTypes.Any(e => e.Id == id);
        }
    }
}
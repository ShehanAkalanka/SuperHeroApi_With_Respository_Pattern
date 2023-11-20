using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApi.Models;
using SuperHeroApi.Services.SuperheroService;

namespace SuperHeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroController : ControllerBase
    {
        private readonly ISuperheroService _superheroService;

        public SuperheroController(ISuperheroService superheroService)
        {
            _superheroService = superheroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Superhero>>> GetAllHeros()
        {
            return Ok(await _superheroService.GetAllHeros());
             
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Superhero>>> GetAllHeros(int id)
        {
            return Ok(await _superheroService.GetSingleHero(id));

        }


        [HttpPost]
        public async Task<ActionResult<List<Superhero>>> AddSuperhero(Superhero request)
        {
            var result = await _superheroService.AddHero(request);
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Superhero>>> UpdateSuperhero(int id,Superhero request)
        {
            var result = await _superheroService.UpdateHero(id,request);
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Superhero>>> DeleteSuperhero(int id)
        {
            var result = await _superheroService.DeleteHero(id);
            return Ok(result);

        }
    }
}

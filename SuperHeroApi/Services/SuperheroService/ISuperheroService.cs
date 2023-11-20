using SuperHeroApi.Models;

namespace SuperHeroApi.Services.SuperheroService
{
    public interface ISuperheroService
    {
        Task<List<Superhero>> GetAllHeros();
        Task<Superhero?> GetSingleHero(int id);
        Task<List<Superhero>?> AddHero(Superhero superhero);
        Task<List<Superhero>?> UpdateHero(int id, Superhero superhero);
        Task<List<Superhero>?> DeleteHero(int id);
    }
}

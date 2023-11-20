using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Data;
using SuperHeroApi.Models;

namespace SuperHeroApi.Services.SuperheroService
{
    public class SuperheroService : ISuperheroService
    {
        private readonly SuperHeroApiDbContext _dataContext;

        public SuperheroService(SuperHeroApiDbContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Superhero>?> AddHero(Superhero superhero)
        {
            _dataContext.Add(superhero);
            await _dataContext.SaveChangesAsync();
            return await _dataContext.Superheroes.ToListAsync();
        }

        public async Task<List<Superhero>?> DeleteHero(int id)
        {
            var hero = await _dataContext.Superheroes.FirstOrDefaultAsync(c => c.Id == id);
            if (hero == null)
                return null;
            _dataContext.Superheroes.Remove(hero);
            await _dataContext.SaveChangesAsync();
            return await _dataContext.Superheroes.ToListAsync();

        }

        public async Task<List<Superhero>> GetAllHeros()
        {
            var heros = await _dataContext.Superheroes.ToListAsync();
            return heros;
        }

        public async Task<Superhero?> GetSingleHero(int id)
        {
            var hero = await _dataContext.Superheroes.FirstOrDefaultAsync(c => c.Id == id);
            if (hero == null)
                return null;
            return hero;
        }

        public async Task<List<Superhero>?> UpdateHero(int id, Superhero superhero)
        {
            var hero = await _dataContext.Superheroes.FirstOrDefaultAsync(c => c.Id == id);
            if (hero == null)
                return null;
            hero.FirstName = superhero.FirstName;
            hero.LastName = superhero.LastName;
            hero.Name = superhero.Name;

            await _dataContext.SaveChangesAsync();

            return await _dataContext.Superheroes.ToListAsync();
        }
    }
}

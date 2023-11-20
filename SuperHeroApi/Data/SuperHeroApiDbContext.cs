using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Models;

namespace SuperHeroApi.Data
{
    public class SuperHeroApiDbContext:DbContext
    {
        public SuperHeroApiDbContext(DbContextOptions<SuperHeroApiDbContext> options):base(options)
        {
            
        }
        public DbSet<Superhero> Superheroes { get; set; }
    }
}

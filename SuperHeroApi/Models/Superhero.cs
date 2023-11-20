using System.ComponentModel.DataAnnotations;

namespace SuperHeroApi.Models
{
    public class Superhero
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Animal_Shelter.Models
{
  public class Animal_ShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public Animal_ShelterContext(DbContextOptions options) : base(options) { }
  }
}
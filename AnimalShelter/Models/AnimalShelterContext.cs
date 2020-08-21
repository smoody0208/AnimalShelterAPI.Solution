using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    } 
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Shelter> Shelters { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, ShelterId = 1, Age = 4, Name = "Leo", Gender = "Male", Species = "Dog", Breed = "German Shepard", Description = "Well behaved and playful!" },
        new Animal { AnimalId = 2, ShelterId = 1, Age = 2, Name = "Kitty", Gender = "Female", Species = "Cat", Breed = "N/A", Description = "Sometimes grumpy, but usually friendly" },
        new Animal { AnimalId = 3, ShelterId = 2, Age = 20, Name = "Birdy", Gender = "Female", Species = "Bird", Breed = "Parrot", Description = "Likes to talk and yell" } 
      );

      builder.Entity<Shelter>()
      .HasData(
        new Shelter { ShelterId = 1, Location = "Four Paws Rescue" },
        new Shelter { ShelterId = 2, Location = "Meowin Rescue" }
      );
    }
  }
}  
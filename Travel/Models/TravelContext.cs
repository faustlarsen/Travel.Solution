using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options)
        : base(options)
    {
      
    }

    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
          .HasData(
              new Review { ReviewId = 1, Country = "USA", City = "Seattle, WA", Text = "Great city", Author= "John Snow", Rating = 5},
              new Review { ReviewId = 2, Country = "USA", City = "Los Angeles, CA", Text = "Dirty city", Author= "Pamela Anderson", Rating = 4 },
              new Review { ReviewId = 3, Country = "USA", City = "Tucson, Az", Text = "Hot city", Author= "John Sun", Rating = 3 },
              new Review { ReviewId = 4, Country = "Russia", City = "Tomsk", Text = "Cold city", Author= "John Snow", Rating = 2 },
              new Review { ReviewId = 5, Country = "Belarus", City = "Mogilev", Text = "Terrible city", Author= "A. Lukashenko", Rating = 1 },
              new Review { ReviewId = 6, Country = "Belarus", City = "Minsk", Text = "OK city", Author= "Serge Bash", Rating = 1 }
          );
    }
  }
}
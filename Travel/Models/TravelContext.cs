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
    // public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
          .HasData(
              new Review { ReviewId = 1, Country = "USA", City = "Seattle, WA", ReviewText = "Great city", Author= "John Snow", Rating = 5},
              new Review { ReviewId = 2, Country = "USA", City = "Los Angeles, CA", ReviewText = "Dirty city", Author= "Pamela Anderson", Rating = 4 },
              new Review { ReviewId = 3, Country = "USA", City = "Tucson, Az", ReviewText = "Hot city", Author= "John Sun", Rating = 3 },
              new Review { ReviewId = 4, Country = "Russia", City = "Tomsk", ReviewText = "Cold city", Author= "John Snow", Rating = 2 },
              new Review { ReviewId = 5, Country = "Belarus", City = "Mogilev", ReviewText = "Terrible city", Author= "A. Lukashenko", Rating = 1 },
              new Review { ReviewId = 6, Country = "Belarus", City = "Minsk", ReviewText = "OK city", Author= "Serge Bash", Rating = 1 }
          );
      // builder.Entity<User>()
      //     .HasData(
      //       new User {UserId=1, UserName="user1", Password="123"},
      //       new User {UserId=2, UserName="user2", Password="123"}
      //     );
    }

  }
}
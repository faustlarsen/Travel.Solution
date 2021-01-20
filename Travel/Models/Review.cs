using System.ComponentModel.DataAnnotations;
namespace Travel.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    [Required]
    [StringLength(20)]
    public string Country { get; set; }
    [Required]
    [StringLength(20)]
    public string City { get; set; }
    [Required]
    [StringLength(1000)]
    public string ReviewText { get; set; }
    [Required]
    [StringLength(20)]
    public string Author { get; set; }
    [Required]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]

    public int Rating { get; set; }
  }
}
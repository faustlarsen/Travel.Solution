using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelContext _db;
    public ReviewsController(TravelContext db)
    {
      _db = db;
    }

    //Get api/reviews
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string country, string city, string author, int rating, bool random)
    {
      var query = _db.Reviews.AsQueryable();
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (author != null)
      {
        query = query.Where(entry => entry.Author == author);
      }

      if (rating == 1 || rating == 2 || rating == 3 || rating == 4 || rating == 5)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      if (random != false)
      {
        Random rnd = new Random();
        List<Review> returnedId = _db.Reviews.ToList();
      
        int randomReview = rnd.Next(1,6); //5
        query = query.Where(entry => entry.ReviewId == randomReview);
      }

      return query.ToList();
    }


//Post api/reviews
[HttpPost]
public void Post([FromBody] Review review)
{
  _db.Reviews.Add(review);
  _db.SaveChanges();
}

// GET api/reviews/1
[HttpGet("{id}")]
public ActionResult<Review> Get(int id)
{
  return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
}

//Put api/review/5
[HttpPut("{id}")]
public void Put(int id, string user_name, [FromBody] Review review)
{
  review.ReviewId = id;
  if (review.Author == user_name)
  {
    _db.Entry(review).State = EntityState.Modified;
    _db.SaveChanges();
  }
  // else 
  // {
  //   return "You don't have a permission to change that";
  // }

}

// DELETE api/review/5
[HttpDelete("{id}")]
public void Delete(int id, string user_name, [FromBody] Review review)
{
  var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);

  review.ReviewId = id;
  if (review.Author == user_name)
  {
    _db.Reviews.Remove(reviewToDelete);
    _db.SaveChanges();
  }
}
  }
}
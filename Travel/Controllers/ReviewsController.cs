using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Microsoft.EntityFrameworkCore;

namespace Travel.Controllers
{
  [Route("api/[controller")]
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
    public ActionResult<IEnumerable<Review>> Get()
    {
      return _db.Reviews.ToList();
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
    [HttpPut("{id")]
    public void Put (int id, [FromBody] Review review)
    {
        review.ReviewId = id;
        _db.Entry(review).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // DELETE api/review/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
      _db.Reviews.Remove(reviewToDelete);
      _db.SaveChanges();
    }
    
  }
}

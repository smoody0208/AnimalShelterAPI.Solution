using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SheltersController : ControllerBase
  {
    private AnimalShelterContext _db;

    public SheltersController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Shelter>> Get(string location)
    {
      var query = _db.Shelters.AsQueryable();

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Shelter shelter)
    {
      _db.Shelters.Add(shelter);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Shelter> Get(int id)
    {
      Shelter thisShelter = _db.Shelters
      .Include(shelter => shelter.Animals)
      .FirstOrDefault(entry => entry.ShelterId == id);
      return thisShelter;
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shelter shelter)
    {
      shelter.ShelterId = id;
      _db.Entry(shelter).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shelterToDelete = _db.Shelters.FirstOrDefault(entry => entry.ShelterId == id);
      _db.Shelters.Remove(shelterToDelete);
      _db.SaveChanges();
    }
  }
}
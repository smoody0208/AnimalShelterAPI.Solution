using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Shelter
  {
    public Shelter()
    {
      this.Animals = new HashSet<Animal>();
    }
    public int ShelterId { get; set; }
    public string Location { get; set;}
    public ICollection<Animal> Animals { get; set; }
  }
}
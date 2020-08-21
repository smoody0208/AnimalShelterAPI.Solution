using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public int ShelterId { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public string Description { get; set; }
  }
}
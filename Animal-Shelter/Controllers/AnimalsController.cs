using Microsoft.AspNetCore.Mvc;
using Animal_Shelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Animal_Shelter.Controllers
{
  public class Animal_Shelter : Controller
  {
    private readonly Animal_ShelterContext _db;
    public AnimalsController(Animal_ShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animals.AnimalId == id);
      return View(thisAnimal);
    }
  }
}
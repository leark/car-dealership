using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult ShowCars()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult NewCar()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult NewCar(string makeModel, int price, int miles)
    {
      Car newCar = new Car(makeModel, price, miles);
      return RedirectToAction("ShowCars");
    }
  }
}
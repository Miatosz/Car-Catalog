using System.Collections.Generic;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;
using CarCatalog.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService repo)
        {
            this._carService = repo;
        }

        [HttpGet(Name = "AllCars")]
        public ActionResult<IEnumerable<Car>> Get() => Ok(_carService.GetAllCars());
        
        [HttpPost(Name = "AddCar")]
        public ActionResult<Car> CreateCar(Car car)
        {
            var result = _carService.AddCar(car);
            if (_carService.SaveChanges()) 
                return Ok(result);
            return BadRequest("Cannot add car");
        }

    }
}
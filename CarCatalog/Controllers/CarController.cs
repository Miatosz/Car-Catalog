using System.Collections.Generic;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;
using CarCatalog.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository repo)
        {
            this._carRepository = repo;
        }

        [HttpGet(Name = "GetAllCars")]
        public ActionResult<IEnumerable<Car>> Get() => Ok(_carRepository.GetAllCars());

        [HttpPost(Name = "AddCar")]
        public ActionResult<Car> CreateCar(Car car)
        {
            var result = _carRepository.AddCar(car);
            if (_carRepository.SaveChanges()) 
                return Ok(result);
            return BadRequest("Cannot add car");

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDBContext _context;

        public CarRepository(AppDBContext ctx)
        {
            _context = ctx;
        }


        public IEnumerable<Car> GetAllCars() => _context.Cars.ToList();

        public IEnumerable<Car> GetCarsByManufacturer(Manufacturer manufacturer) =>
            _context.Cars.ToList().FindAll(car => car.Manufacturer == manufacturer);

        public IEnumerable<Car> GetCarsByBodyType(BodyStyle bodyStyle) =>
            _context.Cars.ToList().FindAll(car => car.BodyStyles.Contains(bodyStyle));

        public IEnumerable<Car> GetCarsByProductionYears(int startDate, int endDate) => _context.Cars.ToList()
            .FindAll(car => car.StartProductionDate >= startDate && car.EndProductionDate <= endDate);

        public Car GetCarById(int id) => _context.Cars.ToList().First(x => x.CarID == id);

        public Car AddCar(Car car)
        {
            try
            {
                return _context.Cars.Add(car).Entity;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

        public bool RemoveCar(int id) => _context.Cars.ToList().Exists(car => car.CarID == id);

        public bool SaveChanges() => (_context.SaveChanges() >= 0);




    }
}

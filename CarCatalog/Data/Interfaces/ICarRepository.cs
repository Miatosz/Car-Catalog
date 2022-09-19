using System.Collections.Generic;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        IEnumerable<Car> GetCarsByManufacturer(Manufacturer manufacturer);
        IEnumerable<Car> GetCarsByBodyType(BodyStyle bodyStyle);
        IEnumerable<Car> GetCarsByProductionYears(int startDate, int endDate);
        Car GetCarById(int id);
        Car AddCar(Car car);
        bool RemoveCar(int id);
        bool SaveChanges();
    }
}
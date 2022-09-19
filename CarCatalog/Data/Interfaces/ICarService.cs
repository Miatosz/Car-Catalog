using System.Collections.Generic;
using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface ICarService
    {
        Task<IEnumerable<CarDto>> GetAllCars();
        Task<IEnumerable<CarDto>> GetCarsByManufacturer(Manufacturer manufacturer);
        Task<IEnumerable<CarDto>> GetCarsByBodyType(BodyStyle bodyStyle);
        Task<IEnumerable<CarDto>> GetCarsByProductionYears(int startDate, int endDate);
        Task<CarDto> GetCarById(int id);
        Task<CarDto> AddCar(Car car);
        bool RemoveCar(int id);
        bool SaveChanges();
    }
}
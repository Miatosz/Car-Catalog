using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Data.Services
{
    public class CarService : ICarService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public CarService(AppDBContext ctx, IMapper mp)
        {
            _mapper = mp;
            _context = ctx;
        }


        public async Task<IEnumerable<CarDto>> GetAllCars() => await _mapper.Map<Task<IEnumerable<CarDto>>>(_context.Cars.ToList());
        public async Task<IEnumerable<CarDto>> GetCarsByManufacturer(Manufacturer manufacturer) =>
            await _mapper.Map<Task<IEnumerable<CarDto>>>(_context.Cars.ToList().FindAll(car => car.Manufacturer == manufacturer)); 

        public async Task<IEnumerable<CarDto>> GetCarsByBodyType(BodyStyle bodyStyle) =>
            await _mapper.Map<Task<IEnumerable<CarDto>>>(_context.Cars.ToList().FindAll(car => car.BodyStyles.Contains(bodyStyle))); 

        public async Task<IEnumerable<CarDto>> GetCarsByProductionYears(int startDate, int endDate) => await _mapper.Map<Task<IEnumerable<CarDto>>>(_context.Cars.ToList()
            .FindAll(car => car.StartProductionDate >= startDate && car.EndProductionDate <= endDate)); 

        public async Task<CarDto> GetCarById(int id) => await _mapper.Map<Task<CarDto>>(_context.Cars.FirstAsync(x => x.CarID == id).Result);

        public async Task<CarDto> AddCar(Car car)
        {
            try
            {
                return await _mapper.Map<Task<CarDto>>(_context.Cars.AddAsync(car).Result.Entity);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

        public bool RemoveCar(int id)
        {
            var car = _context.Cars.ToList().Where(car => car.CarID == id);

            if (!car.Any()) return false;
            _context.Cars.Remove(car.First());
            return true;
            
        }

        public bool SaveChanges() => (_context.SaveChanges() >= 0);




    }
}

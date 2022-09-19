using System.Collections.Generic;
using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface IFuelTypeService
    {
        Task<IEnumerable<FuelTypeDto>> GetAllFuelTypes();
        Task<FuelTypeDto> GetFuelTypeById(int id);
        bool SaveChanges();
    }
}
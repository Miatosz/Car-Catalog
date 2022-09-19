using System.Collections.Generic;
using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface IManufacturerService
    {
        Task<ManufacturerDto> GetManufacturerById(int id);
        Task<IEnumerable<ManufacturerDto>> GetAllManufacturers();
        bool SaveChanges();
    }
}
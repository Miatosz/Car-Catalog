using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface IEngineTypeService
    {
        Task<EngineTypeDto> GetEngineTypeById(int id);
        bool SaveChanges();
    }
}
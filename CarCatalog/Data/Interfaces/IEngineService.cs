using System.Threading.Tasks;
using CarCatalog.Data.Models.DTOs;
using CarCatalog.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface IEngineService
    {
        Task<EngineDto> GetEngineById(int id);
        bool SaveChanges();
    }
}
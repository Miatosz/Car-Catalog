using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface IEngineTypeRepository
    {
        EngineType GetEngineTypeById(int id);
    }
}
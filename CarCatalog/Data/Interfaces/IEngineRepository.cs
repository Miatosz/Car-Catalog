using CarCatalog.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface IEngineRepository
    {
        Engine GetEngineById(int id);
    }
}
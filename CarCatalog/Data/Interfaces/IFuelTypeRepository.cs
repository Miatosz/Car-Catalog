using System.Collections.Generic;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface IFuelTypeRepository
    {
        IEnumerable<FuelType> GetAllFuelTypes();
        FuelType GetFuelTypeById(int id);
    }
}
using System.Collections.Generic;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface IManufacturerRepository
    {
        Manufacturer GetManufacturerById(int id);
        IEnumerable<Manufacturer> GetAllManufacturers();
    }
}
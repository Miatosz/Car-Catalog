using System.Collections.Generic;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int id);
    }
}
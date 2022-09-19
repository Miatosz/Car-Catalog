using System.Collections.Generic;
using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAllCountries();
        Task<CountryDto> GetCountryById(int id);
        bool SaveChanges();
    }
}
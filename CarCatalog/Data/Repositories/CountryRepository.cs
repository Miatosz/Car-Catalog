using System.Collections.Generic;
using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDBContext _context;
        public CountryRepository(AppDBContext ctx) => _context = ctx;

        public IEnumerable<Country> GetAllCountries() => _context.Countries.ToList();

        public Country GetCountryById(int id) => _context.Countries.ToList().Find(x => x.CountryID == id);

    }
}
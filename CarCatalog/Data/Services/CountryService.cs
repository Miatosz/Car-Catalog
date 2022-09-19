using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Services
{
    public class CountryService : ICountryService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public CountryService(AppDBContext ctx, IMapper mp)
        {
            _context = ctx;
            _mapper = mp;
        }

        public async Task<IEnumerable<CountryDto>> GetAllCountries() => await _mapper.Map<Task<IEnumerable<CountryDto>>>(_context.Countries.ToList());

        public async Task<CountryDto> GetCountryById(int id) => await _mapper.Map<Task<CountryDto>>(_context.Countries.ToList().Find(x => x.CountryID == id));
        public bool SaveChanges() => (_context.SaveChanges() >= 0);
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public ManufacturerService(AppDBContext ctx, IMapper mp)
        {
            _context = ctx;
            _mapper = mp;
        }

        public async Task<ManufacturerDto> GetManufacturerById(int id) =>
            await _mapper.Map<Task<ManufacturerDto>>(_context.Manufacturers.ToList().Find(x => x.ManufacturerId == id));

        public async Task<IEnumerable<ManufacturerDto>> GetAllManufacturers() => await _mapper.Map<Task<IEnumerable<ManufacturerDto>>>(_context.Manufacturers.ToList());
        
        public bool SaveChanges() => (_context.SaveChanges() >= 0);
    }
}
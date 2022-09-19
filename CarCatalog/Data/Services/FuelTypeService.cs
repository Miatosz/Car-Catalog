using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Services
{
    public class FuelTypeService : IFuelTypeService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public FuelTypeService(AppDBContext ctx, IMapper mp)
        {
            _context = ctx;
            _mapper = mp;
        }

        public async Task<IEnumerable<FuelTypeDto>> GetAllFuelTypes() => await _mapper.Map<Task<IEnumerable<FuelTypeDto>>>(_context.FuelTypes.ToList());
        
        public async Task<FuelTypeDto> GetFuelTypeById(int id) => await _mapper.Map<Task<FuelTypeDto>>(_context.FuelTypes.ToList().Find(x => x.FuelTypeID == id));
        
        public bool SaveChanges() => (_context.SaveChanges() >= 0);
    }
}
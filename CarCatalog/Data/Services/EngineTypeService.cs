using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Services
{
    public class EngineTypeService : IEngineTypeService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public EngineTypeService(AppDBContext ctx, IMapper mp)
        {
            _context = ctx;
            _mapper = mp;
        }
        public async Task<EngineTypeDto> GetEngineTypeById(int id) => await _mapper.Map<Task<EngineTypeDto>>(_context.EngineTypes.ToList().Find(x => x.EngineTypeID == id));
        
        public bool SaveChanges() => (_context.SaveChanges() >= 0);
    }
}
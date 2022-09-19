using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Services
{
    public class EngineService : IEngineService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public EngineService(AppDBContext ctx, IMapper mp)
        {
            _context = ctx;
            _mapper = mp;
        }
            
        public async Task<EngineDto> GetEngineById(int id) => await _mapper.Map<Task<EngineDto>>(_context.Engines.ToList().Find(x => x.EngineID == id));
        
        public bool SaveChanges() => (_context.SaveChanges() >= 0);
    }
}
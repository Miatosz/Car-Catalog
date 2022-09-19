using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Models;

namespace CarCatalog.Data.Repositories
{
    public class EngineRepository : IEngineRepository
    {
        private readonly AppDBContext _context;
        public EngineRepository(AppDBContext ctx) => _context = ctx; 
            
        public Engine GetEngineById(int id) => _context.Engines.ToList().Find(x => x.EngineID == id);
    }
}
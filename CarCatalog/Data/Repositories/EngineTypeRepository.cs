using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class EngineTypeRepository : IEngineTypeRepository
    {
        private readonly AppDBContext _context;
        public EngineTypeRepository(AppDBContext ctx) => _context = ctx;

        public EngineType GetEngineTypeById(int id) => _context.EngineTypes.ToList().Find(x => x.EngineTypeID == id);
    }
}
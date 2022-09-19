using System.Collections.Generic;
using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class FuelTypeRepository : IFuelTypeRepository
    {
        private readonly AppDBContext _context;
        public FuelTypeRepository(AppDBContext ctx) => _context = ctx;

        public IEnumerable<FuelType> GetAllFuelTypes() => _context.FuelTypes.ToList();
        
        public FuelType GetFuelTypeById(int id) => _context.FuelTypes.ToList().Find(x => x.FuelTypeID == id);
    }
}
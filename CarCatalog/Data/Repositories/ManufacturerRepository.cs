using System.Collections.Generic;
using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly AppDBContext _context;
        public ManufacturerRepository(AppDBContext ctx) => _context = ctx;

        public Manufacturer GetManufacturerById(int id) =>
            _context.Manufacturers.ToList().Find(x => x.ManufacturerID == id);

        public IEnumerable<Manufacturer> GetAllManufacturers() => _context.Manufacturers.ToList();

    }
}
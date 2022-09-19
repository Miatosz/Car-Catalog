using System.Collections.Generic;
using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class BodyStyleRepository : IBodyStyleRepository
    {
        private readonly AppDBContext _context;
        public BodyStyleRepository(AppDBContext ctx) => _context = ctx;

        public BodyStyle GetBodyStyleById(int id) => _context.BodyStyles.ToList().Find(x => x.BodyStyleID == id);

        public IEnumerable<BodyStyle> GetAllBodyStyles() => _context.BodyStyles.ToList();
    }
}
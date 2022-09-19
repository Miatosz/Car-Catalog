using System.Collections.Generic;
using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class TransmissonTypeRepository : ITransmissionTypeRepository
    {
        private readonly AppDBContext _context;
        public TransmissonTypeRepository(AppDBContext ctx) => _context = ctx;

        public IEnumerable<TransmissionType> GetAllTransmissionTypes() => _context.TransmissionTypes.ToList();

        public TransmissionType GetTransmissionTypeById(int id) =>
            _context.TransmissionTypes.ToList().Find(x => x.TransmissionTypeID == id);
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Services
{
    public class TransmissonTypeService : ITransmissionTypeService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public TransmissonTypeService(AppDBContext ctx, IMapper mp)
        {
            _context = ctx;
            _mapper = mp;
        }

        public async Task<IEnumerable<TransmissionTypeDto>> GetAllTransmissionTypes() => await _mapper.Map<Task<IEnumerable<TransmissionTypeDto>>>(_context.TransmissionTypes.ToList());

        public async Task<TransmissionTypeDto> GetTransmissionTypeById(int id) =>
            await _mapper.Map<Task<TransmissionTypeDto>>(_context.TransmissionTypes.ToList().Find(x => x.TransmissionTypeID == id));
        
        public bool SaveChanges() => (_context.SaveChanges() >= 0);
    }
}
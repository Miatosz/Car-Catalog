using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Services
{
    public class DrivetrainService : IDrivetrainService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public DrivetrainService(AppDBContext ctx, IMapper mp)
        {
            _context = ctx;
            _mapper = mp;
        }

        public async Task<DrivetrainDto> GetDrivetrainById(int id) => await _mapper.Map<Task<DrivetrainDto>>(_context.Drivetrains.ToList().Find(x => x.DrivetrainID == id));
        
        public bool SaveChanges() => (_context.SaveChanges() >= 0);
    }
}
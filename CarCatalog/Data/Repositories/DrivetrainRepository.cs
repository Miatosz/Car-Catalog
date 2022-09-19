using System.Linq;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Repositories
{
    public class DrivetrainRepository : IDrivetrainRepository
    {
        private readonly AppDBContext _context;
        public DrivetrainRepository(AppDBContext ctx) => _context = ctx;

        public Drivetrain GetDrivetrainById(int id) => _context.Drivetrains.ToList().Find(x => x.DrivetrainID == id);
    }
}
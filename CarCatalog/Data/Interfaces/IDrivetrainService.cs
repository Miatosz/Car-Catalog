using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface IDrivetrainService
    {
        Task<DrivetrainDto> GetDrivetrainById(int id);
        bool SaveChanges();
    }
}
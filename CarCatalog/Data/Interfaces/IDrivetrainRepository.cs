using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface IDrivetrainRepository
    {
        Drivetrain GetDrivetrainById(int id);
    }
}
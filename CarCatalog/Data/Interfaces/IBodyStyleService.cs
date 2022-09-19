using System.Collections.Generic;
using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface IBodyStyleService
    {
        Task<BodyStyleDto> GetBodyStyleById(int id);
        Task<IEnumerable<BodyStyleDto>> GetAllBodyStyles();
        bool SaveChanges();
    }
}
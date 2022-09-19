using System.Collections.Generic;
using System.Threading.Tasks;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;

namespace CarCatalog.Data.Interfaces
{
    public interface ITransmissionTypeService
    {
        Task<IEnumerable<TransmissionTypeDto>> GetAllTransmissionTypes();
        Task<TransmissionTypeDto> GetTransmissionTypeById(int id);
        bool SaveChanges();
    }
}
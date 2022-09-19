using System.Collections.Generic;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface ITransmissionTypeRepository
    {
        IEnumerable<TransmissionType> GetAllTransmissionTypes();
        TransmissionType GetTransmissionTypeById(int id);
    }
}
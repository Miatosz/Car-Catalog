using System.Collections.Generic;
using CarCatalog.Data.Models;

namespace CarCatalog.Data.Interfaces
{
    public interface IBodyStyleRepository
    {
        BodyStyle GetBodyStyleById(int id);
        IEnumerable<BodyStyle> GetAllBodyStyles();
    }
}
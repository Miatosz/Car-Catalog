using CarCatalog.Data.Models;

namespace CarCatalog.Models
{
    public class Engine
    {
        public int EngineID { get; set; }
        public int EngineCapacity { get; set; }
        public int EnginePower { get; set; }
        public int EngineTorque { get; set; }
        public int NumberOfCylinders { get; set; }


        public int EngineTypeID { get; set; }
        public EngineType EngineType { get; set; }
        public int FuelTypeID { get; set; }
        public FuelType FuelType { get; set; }
    }
}

namespace CarCatalog.Data.Models.DTOs
{
    public class EngineDto
    {
        public int EngineCapacity { get; set; }
        public int EnginePower { get; set; }
        public int EngineTorque { get; set; }
        public int NumberOfCylinders { get; set; }


        public int EngineTypeId { get; set; }
        public EngineType EngineType { get; set; }
        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }
    }
}
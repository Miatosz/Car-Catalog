using System.Collections.Generic;
using CarCatalog.Models;

namespace CarCatalog.Data.Models.DTOs
{
    public class CarDto
    {
        public string Model { get; set; }
        public int StartProductionDate { get; set; }
        public int EndProductionDate { get; set; }
        public IEnumerable<Engine> AvailableEngines { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }

        public ICollection<BodyStyle> BodyStyles { get; set; }
        public ICollection<TransmissionType> TransmissionTypes { get; set; }
        public ICollection<Drivetrain> Drivetrains { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
    }
}
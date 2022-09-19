using System.Collections.Generic;
using CarCatalog.Models;

namespace CarCatalog.Data.Models
{
    public class Car
    {
        public int CarID { get; set; }
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
        
        //public int TransmissionTypeID { get; set; }
        //public int BodyStyleID { get; set; }
        //public BodyStyle BodyStyle { get; set; }
        //public int ManufacturerID { get; set; }
        //public TransmissionType TransmissionType { get; set; }
        //public int DrivetrainID { get; set; }
        //public Drivetrain Drivetrain { get; set; }


    }
}

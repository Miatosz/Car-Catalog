using AutoMapper;
using CarCatalog.Models;

namespace CarCatalog.Data.Models.DTOs
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<BodyStyle, BodyStyleDto>();
            CreateMap<Car, CarDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Drivetrain, DrivetrainDto>();
            CreateMap<Engine, EngineDto>();
            CreateMap<EngineType, EngineTypeDto>();
            CreateMap<FuelType, FuelTypeDto>();
            CreateMap<Manufacturer, ManufacturerDto>();
            CreateMap<TransmissionType, TransmissionTypeDto>();
        }
    }
}
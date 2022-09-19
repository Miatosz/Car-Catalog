using System.Collections.Generic;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet(Name = "ListManufacturers")]
        public ActionResult<IEnumerable<Manufacturer>> GetAllManufacturers() => Ok(_manufacturerService.GetAllManufacturers());
    }
}
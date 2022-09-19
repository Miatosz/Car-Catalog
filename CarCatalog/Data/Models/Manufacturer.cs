﻿namespace CarCatalog.Data.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public int CountryId { get; set; }
        public Country CountryOrigin { get; set; }
    }
}

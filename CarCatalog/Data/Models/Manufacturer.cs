namespace CarCatalog.Data.Models
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }

        public int CountryID { get; set; }
        public Country CountryOrigin { get; set; }
    }
}

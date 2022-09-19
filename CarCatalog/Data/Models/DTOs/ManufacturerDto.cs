namespace CarCatalog.Data.Models.DTOs
{
    public class ManufacturerDto
    {
        public string ManufacturerName { get; set; }
        public int CountryId { get; set; }
        public Country CountryOrigin { get; set; }
    }
}
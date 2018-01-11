
using LostAndFound.Data.Models.Lookups;

namespace LostAndFound.Data.Models
{
    public class Location : BaseModel
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Suburb { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
    }
}

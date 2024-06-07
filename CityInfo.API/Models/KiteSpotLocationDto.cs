namespace CityInfo.API.Models
{
    public class KiteSpotLocationDto
    {
        public int Id { get; set; }
        public string NameId { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

namespace CityInfo.API.Models
{
    public class KiteSpotLocationDto
    {
        public int Id { get; set; }
        public string NameId { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int BeginnerScore { get; set; }
        public int FreestyleScore { get; set; }
        public int WaveScore { get; set; }
        public ICollection<WindDirectionDescriptionsDto> WindDirectionDescriptions { get; set; } = new List<WindDirectionDescriptionsDto>();
    }
}

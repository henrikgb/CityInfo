namespace CityInfo.API.Models
{
    public class PointsOfInterestDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterests.Count;
            }
        }

        public ICollection<PointsOfInterestDto> PointsOfInterests { get; set; } = new List<PointsOfInterestDto>();
    }
}

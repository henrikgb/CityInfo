namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get;  } = new CitiesDataStore();
        public CitiesDataStore() 
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one with that big park and statue of liberty."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Oslo",
                    Description = "Tigerstaden."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Stavanger",
                    Description = "A beautiful place on earth."
                }
            };
        }
    }
}

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
                    Description = "The one with that big park and statue of liberty.",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the US."
                        },
                        new PointsOfInterestDto
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhatten."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Oslo",
                    Description = "Tigerstaden.",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto
                        {
                            Id = 1,
                            Name = "Oslo S",
                            Description = "The Central Train Station."
                        },
                        new PointsOfInterestDto
                        {
                            Id = 2,
                            Name = "Blindern",
                            Description = "The Campus of Oslo University."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Stavanger",
                    Description = "A beautiful place on earth.",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto
                        {
                            Id = 1,
                            Name = "Mosvannet",
                            Description = "A nice lake."
                        },
                        new PointsOfInterestDto
                        {
                            Id = 2,
                            Name = "Ullandhaug",
                            Description = "The location of the campus for Stavanger University."
                        }
                    }
                }
            };
        }
    }
}

namespace CityInfo.API.Models
{
    public class KiteSpotsLocationDataStore
    {
        public List<KiteSpotLocationDto> Locations { get; set; }
        public static KiteSpotsLocationDataStore Current { get;} = new KiteSpotsLocationDataStore();
        public KiteSpotsLocationDataStore()
        {
            // init dummy data
            Locations = new List<KiteSpotLocationDto>()
            {
            new KiteSpotLocationDto()
            {
                Id = 1,
                NameId = "Sande",
                Latitude = 59.02050003940309,
                Longitude = 5.592325942611728,
                BeginnerScore = 3,
                FreestyleScore = 5,
                WaveScore = 5,
            },
            new KiteSpotLocationDto()
            {
                Id = 2,
                NameId = "Sola",
                Latitude = 58.88531361351894,
                Longitude = 5.602662428854268,
                BeginnerScore = 5,
                FreestyleScore = 4,
                WaveScore = 3,
            },
            new KiteSpotLocationDto()
            {
                Id = 3,
                NameId = "Hellesto",
                Latitude = 58.84227538997773,
                Longitude = 5.560516132410946,
                BeginnerScore = 1,
                FreestyleScore = 3,
                WaveScore = 5,
            },
            new KiteSpotLocationDto()
            {
                Id = 4,
                NameId = "Sele",
                Latitude = 58.81231852222533,
                Longitude = 5.546945324943648,
                BeginnerScore = 1,
                FreestyleScore = 3,
                WaveScore = 5,
            },
            new KiteSpotLocationDto()
            {
                Id = 5,
                NameId = "Bore",
                Latitude = 58.80123195118268,
                Longitude = 5.5480941336096645,
                BeginnerScore = 4,
                FreestyleScore = 3,
                WaveScore = 4,
            },
            new KiteSpotLocationDto()
            {
                Id = 6,
                NameId = "Orre",
                Latitude = 58.740441600947264,
                Longitude = 5.512925570900187,
                BeginnerScore = 4,
                FreestyleScore = 3,
                WaveScore = 4,
            },
            new KiteSpotLocationDto()
            {
                Id = 7,
                NameId = "X",
                Latitude = 58.722027,
                Longitude = 5.521960,
                BeginnerScore = 1,
                FreestyleScore = 4,
                WaveScore = 5,
            },
            new KiteSpotLocationDto()
            {
                Id = 8,
                NameId = "Refsnes",
                Latitude = 58.68756890551574,
                Longitude = 5.551150818355702,
                BeginnerScore = 4,
                FreestyleScore = 5,
                WaveScore = 5,
            },
            new KiteSpotLocationDto()
            {
                Id = 9,
                NameId = "Brusand",
                Latitude = 58.53797648002299,
                Longitude = 5.730672797723366,
                BeginnerScore = 2,
                FreestyleScore = 3,
                WaveScore = 3,
            }
        };
           
      }
   }
}
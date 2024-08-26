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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 10,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 10,
                        IntervalStop = 60,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 60,
                        IntervalStop = 150,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 150,
                        IntervalStop = 190,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 190,
                        IntervalStop = 250,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 250,
                        IntervalStop = 265,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 265,
                        IntervalStop = 305,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 305,
                        IntervalStop = 360,
                        Category = WindCategory.OverLand,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 10,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 10,
                        IntervalStop = 140,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 140,
                        IntervalStop = 165,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 165,
                        IntervalStop = 225,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 225,
                        IntervalStop = 235,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 235,
                        IntervalStop = 275,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 275,
                        IntervalStop = 315,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 315,
                        IntervalStop = 345,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 9,
                        IntervalStart = 345,
                        IntervalStop = 360,
                        Category = WindCategory.SideOffshore,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 10,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 10,
                        IntervalStop = 30,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 30,
                        IntervalStop = 160,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 160,
                        IntervalStop = 190,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 190,
                        IntervalStop = 210,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 210,
                        IntervalStop = 270,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 270,
                        IntervalStop = 310,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 310,
                        IntervalStop = 320,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 9,
                        IntervalStart = 320,
                        IntervalStop = 360,
                        Category = WindCategory.OverLand,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 20,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 20,
                        IntervalStop = 150,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 150,
                        IntervalStop = 170,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 170,
                        IntervalStop = 210,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 210,
                        IntervalStop = 240,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 240,
                        IntervalStop = 280,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 280,
                        IntervalStop = 330,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 330,
                        IntervalStop = 350,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 9,
                        IntervalStart = 350,
                        IntervalStop = 360,
                        Category = WindCategory.SideOffshore,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 10,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 10,
                        IntervalStop = 20,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 20,
                        IntervalStop = 160,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 160,
                        IntervalStop = 175,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 175,
                        IntervalStop = 220,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 220,
                        IntervalStop = 255,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 255,
                        IntervalStop = 295,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 295,
                        IntervalStop = 340,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 9,
                        IntervalStart = 340,
                        IntervalStop = 360,
                        Category = WindCategory.OverLand,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 135,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 135,
                        IntervalStop = 160,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 160,
                        IntervalStop = 180,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 180,
                        IntervalStop = 235,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 235,
                        IntervalStop = 275,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 275,
                        IntervalStop = 315,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 315,
                        IntervalStop = 345,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 345,
                        IntervalStop = 355,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 9,
                        IntervalStart = 355,
                        IntervalStop = 360,
                        Category = WindCategory.Offshore,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 5,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 5,
                        IntervalStop = 160,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 160,
                        IntervalStop = 170,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 170,
                        IntervalStop = 185,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 185,
                        IntervalStop = 245,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 245,
                        IntervalStop = 285,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 285,
                        IntervalStop = 330,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 330,
                        IntervalStop = 355,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 9,
                        IntervalStart = 355,
                        IntervalStop = 360,
                        Category = WindCategory.SideOffshore,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 30,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 30,
                        IntervalStop = 155,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 155,
                        IntervalStop = 180,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 180,
                        IntervalStop = 200,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 200,
                        IntervalStop = 270,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 270,
                        IntervalStop = 310,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 310,
                        IntervalStop = 330,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 330,
                        IntervalStop = 352,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 352,
                        IntervalStop = 360,
                        Category = WindCategory.SideOffshore,
                    },
                }
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
                WindDirectionDescriptions = new List<WindDirectionDescriptionsDto>()
                {
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 1,
                        IntervalStart = 0,
                        IntervalStop = 95,
                        Category = WindCategory.Offshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 2,
                        IntervalStart = 95,
                        IntervalStop = 105,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 3,
                        IntervalStart = 105,
                        IntervalStop = 150,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 4,
                        IntervalStart = 150,
                        IntervalStop = 175,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 5,
                        IntervalStart = 175,
                        IntervalStop = 215,
                        Category = WindCategory.Onshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 6,
                        IntervalStart = 215,
                        IntervalStop = 260,
                        Category = WindCategory.SideOnshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 7,
                        IntervalStart = 260,
                        IntervalStop = 285,
                        Category = WindCategory.OverLand,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 8,
                        IntervalStart = 285,
                        IntervalStop = 315,
                        Category = WindCategory.SideOffshore,
                    },
                    new WindDirectionDescriptionsDto()
                    {
                        Id = 9,
                        IntervalStart = 315,
                        IntervalStop = 360,
                        Category = WindCategory.Offshore,
                    },
                }
            }
        };
           
      }
   }
}
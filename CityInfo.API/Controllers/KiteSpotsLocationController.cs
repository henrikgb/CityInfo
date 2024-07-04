using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/kitespotslocations")]
    public class KiteSpotsLocationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<KiteSpotLocationDto>> GetKiteSpotLocations()
        {
            return Ok(KiteSpotsLocationDataStore.Current.Locations);
        }
        [HttpGet("{id}",  Name = "GetKiteSpotLocation")]
        public ActionResult<KiteSpotLocationDto> GetKiteSpotLocation(int id)
        {
            var locationToReturn = KiteSpotsLocationDataStore.Current.Locations.FirstOrDefault(x => x.Id == id);

            if (locationToReturn == null)
            {
                return NotFound();
            }

            return Ok(locationToReturn);
        }

        [HttpPost]
        public ActionResult<KiteSpotLocationDto> CreateKiteSpotLocation(
            [FromBody] KiteSpotsLocationForCreationDto kiteSpotsLocation)
        {
            var maxLocationId = KiteSpotsLocationDataStore.Current.Locations.Max(x => x.Id);

            var newLocation = new KiteSpotLocationDto()
            {
                Id = ++maxLocationId,
                NameId = kiteSpotsLocation.NameId,
                Latitude = kiteSpotsLocation.Latitude,
                Longitude = kiteSpotsLocation.Longitude,
            };

            KiteSpotsLocationDataStore.Current.Locations.Add(newLocation);

            return CreatedAtRoute("GetKiteSpotLocation",
                new
                {
                    id = newLocation.Id
                },
                newLocation);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateKiteSpotsLocation(int id, KiteSpotsLocationForUpdateDto kiteSpotLocation)
        {
            var location = KiteSpotsLocationDataStore.Current.Locations.FirstOrDefault(l => l.Id == id);
            if (location == null)
            {
                return NotFound();
            }

            location.NameId = kiteSpotLocation.NameId;
            location.Longitude = kiteSpotLocation.Longitude;
            location.Latitude = kiteSpotLocation.Latitude;

            return NoContent();

        }
    }
}
using CityInfo.API.Models;
using Microsoft.AspNetCore.JsonPatch;
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

        [HttpPatch("{id}")]
        public ActionResult PartiallyUpdateKiteSpotsLocation(int id, JsonPatchDocument<KiteSpotsLocationForUpdateDto> patchDocument)
        {
            var location = KiteSpotsLocationDataStore.Current.Locations.FirstOrDefault(l => l.Id == id);
            if (location == null)
            {
                return NotFound();
            }

            var locationToPatch = new KiteSpotsLocationForUpdateDto()
            {
                NameId = location.NameId,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
            };
            patchDocument.ApplyTo(locationToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(locationToPatch))
            {
                return BadRequest(ModelState);
            }

            location.NameId = locationToPatch.NameId;
            location.Latitude = locationToPatch.Latitude;
            location.Longitude = locationToPatch.Longitude; 

            return NoContent();
        }

    }
}
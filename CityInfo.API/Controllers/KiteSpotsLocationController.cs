using CityInfo.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/kitespotslocations")]
    public class KiteSpotsLocationController : ControllerBase
    {
        private readonly ILogger<KiteSpotsLocationController> _logger;

        public KiteSpotsLocationController(ILogger<KiteSpotsLocationController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

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
                _logger.LogInformation($"Kitespot location with id {id} was not found when using GetKiteSpotLocation request.");
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
                BeginnerScore = kiteSpotsLocation.BeginnerScore,
                FreestyleScore = kiteSpotsLocation.FreestyleScore,
                WaveScore = kiteSpotsLocation.WaveScore,
                WindDirectionDescriptions = kiteSpotsLocation.WindDirectionDescriptions
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
                _logger.LogInformation($"Kitespot location with id {id} was not found when using UpdateKiteSpotsLocation request.");
                return NotFound();
            }

            location.NameId = kiteSpotLocation.NameId;
            location.Longitude = kiteSpotLocation.Longitude;
            location.Latitude = kiteSpotLocation.Latitude;
            location.BeginnerScore = kiteSpotLocation.BeginnerScore;
            location.FreestyleScore = kiteSpotLocation.FreestyleScore;
            location.WaveScore = kiteSpotLocation.WaveScore;
            location.WindDirectionDescriptions = kiteSpotLocation.WindDirectionDescriptions;

            return NoContent();

        }

        [HttpPatch("{id}")]
        public ActionResult PartiallyUpdateKiteSpotsLocation(int id, JsonPatchDocument<KiteSpotsLocationForUpdateDto> patchDocument)
        {
            var location = KiteSpotsLocationDataStore.Current.Locations.FirstOrDefault(l => l.Id == id);
            if (location == null)
            {
                _logger.LogInformation($"Kitespot location with id {id} was not found when using PartiallyUpdateKiteSpotsLocation request.");
                return NotFound();
            }

            var locationToPatch = new KiteSpotsLocationForUpdateDto()
            {
                NameId = location.NameId,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                BeginnerScore = location.BeginnerScore,
                FreestyleScore = location.FreestyleScore,
                WaveScore = location.WaveScore,
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
            location.BeginnerScore = locationToPatch.BeginnerScore;
            location.FreestyleScore = locationToPatch.FreestyleScore;
            location.WaveScore = locationToPatch.WaveScore;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteKiteSpotLocation(int id)
        {
            var location = KiteSpotsLocationDataStore.Current.Locations.FirstOrDefault(l => l.Id == id);
            if (location == null)
            {
                _logger.LogInformation($"Kitespot location with id {id} was not found when using DeleteKiteSpotLocation request.");
                return NotFound();
            }

            KiteSpotsLocationDataStore.Current.Locations.Remove(location);
            return NoContent();
        }

    }
}
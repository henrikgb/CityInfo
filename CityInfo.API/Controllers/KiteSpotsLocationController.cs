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
        [HttpGet("{id}")]
        public ActionResult<KiteSpotLocationDto> GetKiteSpotLocation(int id)
        {
            // Find city
            var locationToReturn = KiteSpotsLocationDataStore.Current.Locations.FirstOrDefault(x => x.Id == id);

            if (locationToReturn == null)
            {
                return NotFound();
            }

            return Ok(locationToReturn);
        }
    }
}
using CitiesInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CitiesInfo.API.Controllers
{
    /*
     * Extending from controller don't needed when building an api
     * Routing matches a request URI to an action on a ctroller
     * To set up end point routing , two pieces of middleware must be injected
     * in the request pipeline
     * app.UseRouting()
     * - marks the decision in the middleware pipeline where a routing decision
     *   is made
     * app.UseEndPoints()
     * - marks the position in the middleware pipeline where the selected endpoint
     *   is executted
     * Attribute-based Routing 
     * Use attributes at controller and action level:
     * [Route],[HttpGet]
     * Combined with a URI template,requests are matched to controller actions
     * For all common HTTP methods, a matching attribute exists
     * - [HttpGet] , [HttpPost] [HttpPatch]
     * 
     * Status Code tell the consumer of the api
     * - if the request was true
     * - if the request was not good
     */
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;

        public CitiesController(CitiesDataStore citiesDataStore)
        {
            _citiesDataStore = citiesDataStore ?? throw new ArgumentNullException(nameof(_citiesDataStore));
        }

        [HttpGet]
        public ActionResult<IEnumerable<CityDTO>> GetCities()
        {
            return Ok(_citiesDataStore.Cities);
        }


        [HttpGet("{id}")]
        public ActionResult<CityDTO> GetCity(int id)
        {
            // find city
            var cityToReturn = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);


            //return new JsonResult(
            //    CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == id));
        }
    }
}

using AutoMapper;
using CitiesInfo.API.Models;
using CitiesInfo.API.Services;
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
     * 
     * I inject the contract and not the exact repo implementation
     */
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityInfoRepository _cityInfoRepository;
        private readonly IMapper _mapper;

        public CitiesController(ICityInfoRepository cityInfoRepository,
            IMapper mapper)
        {
            _cityInfoRepository = cityInfoRepository ?? throw new ArgumentNullException(nameof(cityInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /*
         * We have got mapping code here to map a cityEntity to a CityDto
         * Just imagine this for an object with 20 properties of which 5 are 
         * collection on types that, again, have 10s of properties.
         * We inject in the constructor a new IMapper implementing instance
         */
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterestDto>>> GetCities()
        {
            var cityEntities = await _cityInfoRepository.GetCitiesAsync();

            return Ok(_mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities));

            //var results = new List<CityWithoutPointsOfInterestDto>();
            //foreach (var cityEntity in cityEntities)
            //{
            //    results.Add(new CityWithoutPointsOfInterestDto
            //    {
            //        Id = cityEntity.Id,
            //        Description = cityEntity.Description,
            //        Name = cityEntity.Name,
            //    });
            //}
            // As we creating the mapping from entity to the DTO,
            // it will use that mapping to map each item in the source list 
            // to an item in the destination list.
            // And that destination list, that is what we return.

           // return Ok(_citiesDataStore.Cities);
        }


        [HttpGet("{id}")]
        public async  Task<IActionResult> GetCity(
            int id, bool includePointsOfInterest = false)
        {
            var city = await _cityInfoRepository.GetCityAsync(id, includePointsOfInterest);

            if (city is null)
            {
                return NotFound();
            }
            // we have to map this result either to a CityWithoutPointsOfInterestDto or 
            // to a CityDto.
            // We must create a mapping from the CityEntity to the CityDTO

            if (includePointsOfInterest)
            {
                return Ok(_mapper.Map<CityDTO>(city));
            }
            return Ok(_mapper.Map<CityWithoutPointsOfInterestDto>(city));

            //return new JsonResult(
            //    CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == id));
        }
    }
}

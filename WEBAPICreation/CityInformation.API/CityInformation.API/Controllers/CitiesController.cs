using Microsoft.AspNetCore.Mvc;

namespace CityInformation.API.Controllers
{
    //strictly necessary
    [ApiController]
    [Route("api/cities")]// cities is the prefix of the controller class name
    public class CitiesController : ControllerBase
    {
        // ControllerBase contains basic functionality controllers need like access to the model state, the current user and common 
        // methods for returning responses

        // a controller typically contain other actions, for example to get a single city or create and update 

        // if we do a request with the true path but does not exist the model the framework does not automatically return 404
        // because the uri can be routed, but null is not a correct result we should return status codes
        // to cosnusme an api consumer send and http request like get method 
        // and get an thhp response which contqains status code 
        // Status Codes tell the consumer of an api like a client-side web app can inspect to know whether a request worked 
        // out as expected  and if something is wrong what is the reason or fault of the api itself
        // common mistakes : Don't send back a 200 ok when something went's wrong 
        // Don't send back a 500 internal server error when the client makes a mistake

        // The Importance of status codes 
        // 1) Level 100 Informational : they are typically not used by api's 
        // 2) Level 200 Success: the request went well 
        //                      - 200-OK , for a succesfull GET request
        //                      - 201-Created, In the creation of a new resource 
        //                      - 204-NoContent, For a succesfull request that should not return anything like delete
        // 3)Level 300 Redirection: 
        // 4) Level 400 Clinet Mistake:  400- Bad Request
        //                               401 - Unauthorized invalid authentication details 
        //                               403 - Forbiden the authenticated user does not have access to the requested resource
        //                               404 - Not Found requested resource dpes not exists
        //                               409 - Conflict an edit confilict between two simultaneous updates.

        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}

using AutoMapper;

namespace CitiesInfo.API.Profiles
{
    // will derived from Automapper Profile class
    public class CityProfile : Profile
    {
        // to add a mapping configuration we using a constructor
        // what we want to do is to create a map from the City Entity 
        // to the CityWithoutPointsOfInterestDTOs
        // by default will ignore NullReferenceExceptions from source to target.
        // From time to time we have to provide our own property mappings 
        // but for a lot of objects, this is sufficient
        public CityProfile()
        {
            CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
            CreateMap<Entities.City, Models.CityDTO>();
        }
    }
}

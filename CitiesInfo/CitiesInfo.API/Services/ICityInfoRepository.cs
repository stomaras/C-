using CitiesInfo.API.Entities;

namespace CitiesInfo.API.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();

        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);

        Task<bool> CityExistsAsync(int cityId);

        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsync(int cityId);

        Task<PointOfInterest?> GetPointOfInterestForCityAsync(int cityId, int pointOfInterestId);

        Task AddPointOfInterestForCityAsync(int cityId, PointOfInterest pointOfInterest);

        void DeletePointOfInterest(PointOfInterest pointOfInterest);
        Task<bool> SaveChangesAsync();
    }
}

/*
 * When we get a city we get point of interest for that city
 * But we can choose to include them or not , so what we will do is not including them 
 * when we return a list of cities but allow the consumer to choose 
 * whether or not including when we fetch an additional trip.
 * 
 * 
 * 
 * 
 */

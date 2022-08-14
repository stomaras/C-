using CitiesInfo.API.Models;

namespace CitiesInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDTO> Cities { get; set; }

        // Singleton Pattern
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urbvan park in the USA"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscrapper located in Midtown Manhattan"
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished"
                   
                },
                new CityDTO(){
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Lourve",
                            Description = " The world's largest museum"
                        }
                    }
                }
            };
        }
    }
}

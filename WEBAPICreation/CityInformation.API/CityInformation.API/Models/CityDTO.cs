namespace CityInformation.API.Models
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public string? Description { get; set; }


        // city DTO may contains calculated fields like NumberOfPointsOfInterest
        public int NumberOfPointsOfInterest { get; set; }

        // a person DTO class may contain a FullName Property , which is a concatenation of first name and last name database fields
        // and no part of the city entity class
    }
}

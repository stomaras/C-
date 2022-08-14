namespace CitiesInfo.API.Models
{
    public class PointOfInterestDto
    {
        /*
         * Id is something that we are responsible for is not something 
         * that the consumer of the api is responsible for 
         * Id should not be part of the DTO used for creation 
         */
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}

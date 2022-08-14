namespace CitiesInfo.API.Models
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public string? Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
            = new List<PointOfInterestDto>();

        //public int NumberOfPointsOfInterest { get; set; }

        /*
         * We work with in-memory data
         * NumberOfPointsOfInterest are not part of database
         * calculate in the process
         * 
         */
    }
}

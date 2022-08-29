namespace PrivateSchoolAPI.DTOS
{
    public class CourseForCreationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}

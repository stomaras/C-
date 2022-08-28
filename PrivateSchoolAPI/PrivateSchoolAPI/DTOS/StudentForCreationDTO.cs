namespace PrivateSchoolAPI.DTOS
{
    public class StudentForCreationDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        public CourseDTO Course { get; set; }
    }
}

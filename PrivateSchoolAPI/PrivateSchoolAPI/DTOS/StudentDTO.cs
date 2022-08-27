namespace PrivateSchoolAPI.DTOS
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}" ;
        public int Age { get; set; }

        public CourseDTO CourseDTO { get; set; }
    }
}

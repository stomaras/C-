using PrivateSchoolAPI.DTOS;

namespace PrivateSchoolAPI
{
    public class SchoolDataStore
    {
        public List<CourseDTO> Courses { get; set; }
        public List<StudentDTO> Students { get; set; }

        public static SchoolDataStore Current { get; } = new SchoolDataStore();

        public SchoolDataStore()
        {
            // init dummy data
            Courses = new List<CourseDTO>()
            {
                new CourseDTO(){ Id=1, Name = "Java", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)},
                new CourseDTO(){ Id=2, Name = "C#", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)},
                new CourseDTO(){ Id=3, Name = "Javascript", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)},
                new CourseDTO(){ Id=4, Name = "Python", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)}
            };

            Students = new List<StudentDTO>()
            {
                new StudentDTO() { Id = 1, FirstName = "Spyros", LastName = "Tomaras", Age = 24, CourseDTO = Courses[0] },
                new StudentDTO() { Id = 2, FirstName = "Agathi", LastName = "Tomaras", Age = 22, CourseDTO = Courses[0] },
                new StudentDTO() { Id = 3, FirstName = "Eleni", LastName = "Kallifoni", Age = 60, CourseDTO = Courses[1] },
                new StudentDTO() { Id = 4, FirstName = "Stathis", LastName = "Tomaras", Age = 68, CourseDTO = Courses[1] },
                new StudentDTO() { Id = 5, FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, CourseDTO = Courses[2] },
                new StudentDTO() { Id = 6, FirstName = "Georgia", LastName = "Kallifoni", Age = 55, CourseDTO = Courses[2] },
                new StudentDTO() { Id = 7, FirstName = "Sotiris", LastName = "Kallifonis", Age = 58, CourseDTO = Courses[3] },
                new StudentDTO() { Id = 8, FirstName = "Foris", LastName = "Kallifonis", Age = 27, CourseDTO = Courses[3] },
            };
        }
    }
}


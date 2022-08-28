using PrivateSchoolAPI.DTOS;
using PrivateSchoolAPI.Entities;

namespace PrivateSchoolAPI
{
    public class SchoolDataStore
    {
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }

        public static SchoolDataStore Current { get; } = new SchoolDataStore();

        public SchoolDataStore()
        {
            // init dummy data
            Courses = new List<Course>()
            {
                new Course(){ Id=1, Name = "Java", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)},
                new Course(){ Id=2, Name = "C#", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)},
                new Course(){ Id=3, Name = "Javascript", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)},
                new Course(){ Id=4, Name = "Python", Stream = "CB17", StartDateTime = new DateTime(2023,02,02), EndDateTime = new DateTime(2023,08,02)}
            };

            Students = new List<Student>()
            {
                new Student(){Id = 1, FirstName = "Spyros", LastName = "Tomaras", Age = 24, Course = Courses[0]},
                new Student(){Id = 2, FirstName = "Agathi", LastName = "Tomara", Age = 22, Course = Courses[0]},
                new Student(){Id = 3, FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, Course = Courses[1]},
                new Student(){Id = 4, FirstName = "Xristoforos", LastName = "Kallifonis", Age = 27, Course = Courses[1]},
                new Student(){Id = 5, FirstName = "Yiannis", LastName = "Karakasis", Age = 40, Course = Courses[2]},
                new Student(){Id = 6, FirstName = "Spyridon", LastName = "Tomaras", Age = 47, Course = Courses[2]},
                new Student(){Id = 7, FirstName = "Eleni", LastName = "Kallifoni", Age = 60, Course = Courses[3]},
                new Student(){Id = 8, FirstName = "Georgia", LastName = "Kallifoni", Age = 55, Course = Courses[3]},
            };

           
        }
    }
}


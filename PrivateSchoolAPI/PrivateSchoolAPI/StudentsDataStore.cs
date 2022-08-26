using PrivateSchoolAPI.DTOS;

namespace PrivateSchoolAPI
{
    public class StudentsDataStore
    {

        public List<StudentDTO> Students { get; set; }

        public static StudentsDataStore Current { get; } = new StudentsDataStore();

        public StudentsDataStore()
        {
            // init dummy data
            Students = new List<StudentDTO>()
            {
                new StudentDTO()
                {
                    Id = 1,
                    FirstName = "Spyros",
                    LastName = "Tomaras",
                    Age = 24
                },
                new StudentDTO()
                {
                     Id = 2,
                     FirstName = "Agathi",
                     LastName = "Tomaras",
                     Age = 22
                },
                new StudentDTO()
                {
                    Id = 3,
                    FirstName = "Eleni",
                    LastName = "Kallifoni",
                    Age = 60
                },
            };
        }
    }
}

using PrivateSchoolAPI.Entities;

namespace PrivateSchoolAPI.DTOS
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }
        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public ICollection<StudentDTO> StudentsPerClass { get; set; }
            = new List<StudentDTO>();

        public int NumberOfStudents
        {
            get
            {
                return StudentsPerClass.Count;
            }
        }
    }
}

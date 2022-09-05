namespace PRSchool.Models
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int NumberOfStudents
        {
            get
            {
                return Students.Count;
            }
        }

        public ICollection<StudentDTO> Students { get; set; } = new List<StudentDTO>(); 
    }
}

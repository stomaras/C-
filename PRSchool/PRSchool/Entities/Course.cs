namespace PRSchool.Entities
{
    /*
     * Entities != DTOS.
     */
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Student> Students { get; set; }

        public Course()
        {
            Students = new List<Student>();
        }
    }
}

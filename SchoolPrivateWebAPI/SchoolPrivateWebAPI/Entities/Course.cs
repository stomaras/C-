namespace SchoolPrivateWebAPI.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Stream { get; set;}
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public ICollection<Student> Students { get; set; }
            = new List<Student>();

        public Course(string courseName, string stream)
        {
            CourseName = courseName;
            Stream = stream;
        }
    }
}

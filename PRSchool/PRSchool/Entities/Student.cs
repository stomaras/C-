namespace PRSchool.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Course? Course { get; set; }
        public int CourseId { get; set; }

        
    }
}

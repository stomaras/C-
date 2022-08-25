namespace PrivateSchoolAPI.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

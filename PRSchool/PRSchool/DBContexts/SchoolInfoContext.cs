using Microsoft.EntityFrameworkCore;
using PRSchool.Entities;

namespace PRSchool.DBContexts
{
    /*
     * There is no need for all the entities that map to tables in a database to be in 
     * the same context.Multiple contexts can work on the same database.
     * 
     */
    public class SchoolInfoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public SchoolInfoContext(DbContextOptions<SchoolInfoContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Course> courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "Java"
                },
                new Course()
                {
                    Id = 2,
                    Name = "Python"
                },
                new Course()
                {
                    Id = 3,
                    Name = "C#"
                },
                new Course()
                {
                    Id = 4,
                    Name = "Javascript"
                }
            };
            modelBuilder.Entity<Course>().HasData(courses);

            

            

            List<Student> students = new List<Student>() 
            {
                new Student() { Id = 1, FirstName = "Spyros", LastName = "Tomaras", CourseId = courses[0].Id },
                new Student() { Id = 2, FirstName = "Agathi", LastName = "Tomara", CourseId = courses[0].Id },
                new Student() { Id = 3, FirstName = "Apostolis", LastName = "Papanikoaloy", CourseId = courses[1].Id },
                new Student() { Id = 4, FirstName = "Xristoforos", LastName = "Kallifonis", CourseId = courses[1].Id },
                new Student() { Id = 5, FirstName = "Yiannis", LastName = "Karakasis", CourseId = courses[2].Id },
                new Student() { Id = 6, FirstName = "Ntinos", LastName = "Nikos", CourseId = courses[2].Id },
                new Student() { Id = 7, FirstName = "Natalia", LastName = "Zachanekpliroto", CourseId = courses[3].Id },
                new Student() { Id = 8, FirstName = "Konstantina", LastName = "Nikolatoy", CourseId = courses[3].Id },
            };
            modelBuilder.Entity<Student>().HasData(students);

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}

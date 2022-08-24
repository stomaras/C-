using Microsoft.EntityFrameworkCore;
using SchoolPrivateWebAPI.Entities;

namespace SchoolPrivateWebAPI.Contexts
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;

        public SchoolContext(DbContextOptions<SchoolContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Course)
                .WithMany(b => b.Students)
                .HasForeignKey(s => s.CourseId);

            List<Student> students = new List<Student>();
            students.Add(new Student("Spyros", "Tomaras") { Id = 1, Age = 24});
            students.Add(new Student("Agathi", "Tomara") { Id = 2, Age = 22});
            students.Add(new Student("Apostolis", "Papanikolaoy") { Id = 3, Age = 21 });
            students.Add(new Student("Eleni", "Kallifoni") { Id = 4, Age = 60 });

            modelBuilder.Entity<Student>().HasData(students);

            List<Student> javaStudents = new List<Student>() { students[1] };
            List<Student> csharpStudents = new List<Student>() { students[2] };
            modelBuilder.Entity<Course>().HasData(
                new Course("Java", "CB16")
                {
                    Id = 1,
                    StartDateTime = new DateTime(2023, 02, 02),
                    EndDateTime = new DateTime(2023, 08, 02),
                    Students = javaStudents
                },
                new Course("Csharp", "CB16")
                {
                    Id = 2,
                    StartDateTime = new DateTime(2023, 02, 02),
                    EndDateTime = new DateTime(2023, 08, 02),
                    Students = csharpStudents
                });
            base.OnModelCreating(modelBuilder);
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }


    }
}

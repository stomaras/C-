using Microsoft.EntityFrameworkCore;
using PrivateSchoolAPI.Entities;

namespace PrivateSchoolAPI.Contexts
{
    public class SchoolContext : DbContext
    {

      
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Course>().ToTable("Courses");

            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Student>().HasKey(c => c.Id);

            modelBuilder.Entity<Student>().Property(p => p.Id)
                .HasColumnOrder(1);
            modelBuilder.Entity<Student>().Property(p => p.FirstName)
                .HasColumnOrder(2);
            modelBuilder.Entity<Student>().Property(p => p.LastName)
                .HasColumnOrder(3);
            modelBuilder.Entity<Student>().Property(p => p.Age)
                .HasColumnOrder(4);
            modelBuilder.Entity<Student>().Property(p => p.CourseId)
                .HasColumnOrder(5).IsRequired();

            modelBuilder.Entity<Course>().Property(c => c.Id)
                .HasColumnOrder(1);
            modelBuilder.Entity<Course>().Property(c => c.Name)
                .HasColumnOrder(2);
            modelBuilder.Entity<Course>().Property(c => c.Stream)
                .HasColumnOrder(3);
            modelBuilder.Entity<Course>().Property(c => c.StartDateTime)
                .HasColumnOrder(4);
            modelBuilder.Entity<Course>().Property(c => c.EndDateTime)
                .HasColumnOrder(5);
            
            

            modelBuilder.Entity<Student>()
                .HasOne(c => c.Course)
                .WithMany(s => s.Students)
                .HasForeignKey(c => c.CourseId);

            ICollection<Student> students = new List<Student>();
            ICollection<Course> courses = new List<Course>();

            courses.Add(new Course() 
            {
                Id = 1,
                Name = "Java",
                Stream = "CB16",
                StartDateTime = new DateTime(2023, 02, 02),
                EndDateTime = new DateTime(2023, 08, 02) 
            });
            courses.Add(new Course()
            {
                Id = 2,
                Name = "Csharp",
                Stream = "CB16",
                StartDateTime = new DateTime(2023, 02, 02),
                EndDateTime = new DateTime(2023, 08, 02)
            });
            courses.Add(new Course()
            {
                Id = 3,
                Name = "Javascript",
                Stream = "CB16",
                StartDateTime = new DateTime(2023,02,02),
                EndDateTime = new DateTime(2023,08,02)
            });
            courses.Add(new Course()
            {
                Id = 4,
                Name = "Python",
                Stream = "CB16",
                StartDateTime = new DateTime(2023, 02, 02),
                EndDateTime = new DateTime(2023, 08, 02)
            });

            modelBuilder.Entity<Course>().HasData(courses);

            students.Add(new Student() { Id = 1, FirstName = "Spyros", LastName = "Tomaras", Age = 24, CourseId = 1 });
            students.Add(new Student() { Id = 2, FirstName = "Agathi", LastName = "Tomaras", Age = 22, CourseId = 1 });
            students.Add(new Student() { Id = 3, FirstName = "Eleni", LastName = "Kallifoni", Age = 60, CourseId = 2 });
            students.Add(new Student() { Id = 4, FirstName = "Stathis", LastName = "Tomaras", Age = 65, CourseId = 2 });
            students.Add(new Student() { Id = 5, FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, CourseId = 3 });
            students.Add(new Student() { Id = 6, FirstName = "Xristoforos", LastName = "Kallifonis", Age = 27, CourseId = 3 });
            students.Add(new Student() { Id = 7, FirstName = "Yiannis", LastName = "Karakasis", Age = 39, CourseId = 4 });
            students.Add(new Student() { Id = 8, FirstName = "Xristos", LastName = "Kanoulas", Age = 24, CourseId = 4 });

            modelBuilder.Entity<Student>().HasData(students);

            base.OnModelCreating(modelBuilder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CFE
{
    public class MyContext : DbContext
    {

        public MyContext() : base("Sindesmos")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }

}

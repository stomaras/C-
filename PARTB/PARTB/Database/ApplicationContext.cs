using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(): base("Sindesmos")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Assigment> Assigments { get; set; }
    }
}

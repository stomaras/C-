using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using MVCALLAHector.Models;
using MVCALLAHector.MyContext.Initializers;
namespace MVCALLAHector.MyContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() :base("Sindesmos")
        {
            Database.SetInitializer<ApplicationContext>(new MockupDBInitializer());
            Database.Initialize(false);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }
    }
}
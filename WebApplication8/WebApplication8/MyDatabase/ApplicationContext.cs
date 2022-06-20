using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication8.Models;

namespace WebApplication8.MyDatabase
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Sindesmos")
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }
        
        public DbSet<Manager> Managers { get; set; }
    }
}
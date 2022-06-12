using MVCDAY5Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDAY5Web.Data
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext():base("Sindesmos")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
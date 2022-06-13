using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication6mvc.Models;

namespace WebApplication6mvc.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext():base("Sindesmos")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
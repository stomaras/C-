using MVCDAY4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDAY4.Data
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext():base("Sindesmos")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        
    }
}
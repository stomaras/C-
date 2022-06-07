using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using MVCALLAHector.Models;

namespace MVCALLAHector.MyContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() :base("Sindesmos")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
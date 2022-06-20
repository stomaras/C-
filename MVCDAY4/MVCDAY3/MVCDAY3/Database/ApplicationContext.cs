using MVCDAY3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDAY3.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(): base("Sindesmos")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
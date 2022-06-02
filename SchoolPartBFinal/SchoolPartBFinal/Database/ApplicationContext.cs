using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolPartBFinal.Entities;

namespace SchoolPartBFinal.Database
{
    public class ApplicationContext : DbContext
    { 
        public ApplicationContext() : base("Sindesmos")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}

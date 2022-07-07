using Models;
using MyDatabasee.Initializers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabasee
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("Sindesmos")
        {
            Database.SetInitializer<MyDbContext>(new MockupDbInitializer());
            Database.Initialize(false);
        }
        public DbSet<Product> Products { get; set; }
    }
}

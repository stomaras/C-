using Entities;
using MyDatabase.Initializers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    public class MyApplicationContext : DbContext
    {
        public MyApplicationContext() : base("Sindesmos")
        {
            Database.SetInitializer<MyApplicationContext>(new MockUpDBInitializer());
            Database.Initialize(false);
        }

        public DbSet<Tshirt> Tshirts { get; set; }
        public DbSet<ColorPriceList> colorPriceLists { get; set; }
    }
}

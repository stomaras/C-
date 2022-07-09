using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Initializers
{
    public class MockUpDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Product p1 = new Product() { Name = "Samsung", Price=230,Quantity=4 };
            Product p2 = new Product() { Name = "IPhone", Price=230,Quantity=4 };
            Product p3 = new Product() { Name = "Nokia", Price=250, Quantity=45 };

            context.Products.AddOrUpdate(p1,p2,p3);
            base.Seed(context);
        }

    }


}

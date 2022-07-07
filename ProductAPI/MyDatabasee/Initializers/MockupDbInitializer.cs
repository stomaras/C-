using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabasee.Initializers
{
    public class MockupDbInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            Product p1 = new Product() { Name = "Samsung", Price = 200, Quantity = 10 };
            Product p2 = new Product() { Name = "Iphone8", Price = 500, Quantity = 20 };
            Product p3 = new Product() { Name = "Galaxy", Price = 250, Quantity = 30 };
            Product p4 = new Product() { Name = "Nokia", Price = 100, Quantity = 10 };
            Product p5 = new Product() { Name = "Nokia", Price = 100, Quantity = 10 };

            context.Products.AddOrUpdate(p1, p2, p3, p4, p5);
            base.Seed(context);
        }
    }
}

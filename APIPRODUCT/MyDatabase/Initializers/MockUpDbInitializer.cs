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
            Product p4 = new Product() { Name = "Smart Phone", Price=1000, Quantity=45 };
            Product p5 = new Product() { Name = "Hawaei", Price=400, Quantity=100 };
            Product p6 = new Product() { Name = "Nokia 9", Price=250, Quantity=78 };
            Product p7 = new Product() { Name = "NoK", Price=250, Quantity=78 };
            Product p8 = new Product() { Name = "NoKi", Price=250, Quantity=78 };
            Product p9 = new Product() { Name = "Samsung Galaxy", Price=250, Quantity=78 };
            Product p10 = new Product() { Name = "IPhone 9", Price=500, Quantity=78 };
            Product p11 = new Product() { Name = "IPhone 11", Price=500, Quantity=78 };
            Product p12 = new Product() { Name = "Phone 11", Price=500, Quantity=78 };

            context.Products.AddOrUpdate(p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12);
            base.Seed(context);
        }

    }


}

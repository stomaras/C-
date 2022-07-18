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

           


            Shop s1 = new Shop() { Address = "Greece", Title = "Plaisio" };
            Shop s2 = new Shop() { Address = "USA", Title = "Amazon" };
            Shop s3 = new Shop() { Address = "France", Title = "le coq sportif" };


            Employee e1 = new Employee() { FirstName = "Spyros", LastName = "Tomaras", NumOfKids = 0, AnnualIncome = 12000 };
            Employee e2 = new Employee() { FirstName = "Agathi", LastName = "Tomara", NumOfKids = 0, AnnualIncome = 8000 };
            Employee e3 = new Employee() { FirstName = "Nikos", LastName = "Papanikos", NumOfKids = 2, AnnualIncome = 18000 };
            Employee e4 = new Employee() { FirstName = "Niki", LastName = "Kni", NumOfKids = 2, AnnualIncome = 12000 };
            Employee e5 = new Employee() { FirstName = "Eleni", LastName = "Kallifoni", NumOfKids = 2, AnnualIncome = 6000 };
            Employee e6 = new Employee() { FirstName = "Georgia", LastName = "Kallifoni", NumOfKids = 2, AnnualIncome = 6000 };
            Employee e7 = new Employee() { FirstName = "Giorgos", LastName = "Kallifonis", NumOfKids = 10, AnnualIncome = 12000 };
            Employee e8 = new Employee() { FirstName = "Areti", LastName = "Kallifoni", NumOfKids = 10, AnnualIncome = 10000 };
            Employee e9 = new Employee() { FirstName = "Garifalia", LastName = "Kallifoni", NumOfKids = 0, AnnualIncome = 100000 };
            Employee e10 = new Employee() { FirstName = "Eirini", LastName = "Kallifoni", NumOfKids = 0, AnnualIncome = 10000 };
            Employee e11 = new Employee() { FirstName = "Apostolis", LastName = "Papanikolaoy", NumOfKids = 0, AnnualIncome = 10000 };
            Employee e12 = new Employee() { FirstName = "Maranthi", LastName = "Papanikolaoy", NumOfKids = 0, AnnualIncome = 5000 };
            Employee e13 = new Employee() { FirstName = "Ilias", LastName = "Raptis", NumOfKids = 4, AnnualIncome = 40000 };
            Employee e14 = new Employee() { FirstName = "Nikos", LastName = "Chalimoyrdas", NumOfKids = 1, AnnualIncome = 100000 };
            Employee e15 = new Employee() { FirstName = "Kyriakos", LastName = "Mitsotakis", NumOfKids = 3, AnnualIncome = 2000000 };
            Employee e16 = new Employee() { FirstName = "Jeff", LastName = "Bezos", NumOfKids = 2, AnnualIncome = 1000000000 };
            Employee e17 = new Employee() { FirstName = "Kostas", LastName = "Fragulis", NumOfKids = 2, AnnualIncome = 3000 };
            Employee e18 = new Employee() { FirstName = "Tisiano", LastName = "Bala", NumOfKids = 0, AnnualIncome = 6000 };
            Employee e19 = new Employee() { FirstName = "Natalia", LastName = "Zacharaki", NumOfKids = 0, AnnualIncome = 9000 };
            Employee e20 = new Employee() { FirstName = "Nikos", LastName = "Karanukas", NumOfKids = 2, AnnualIncome = 15000 };
            
            
            //p1.Shop = s1;
            //p2.Shop = s1;
            //p3.Shop = s1;
            //p4.Shop = s2;
            //p4.Shop = s2;
            //p5.Shop = s3;
            s1.Products.Add(p1);
            s1.Products.Add(p2);
            s1.Products.Add(p3);


            s2.Products.Add(p4);
            s2.Products.Add(p5);

            s3.Products.Add(p6);
            s3.Products.Add(p7);
            s3.Products.Add(p8);
            s3.Products.Add(p9);
            s3.Products.Add(p10);
            s3.Products.Add(p11);
            s3.Products.Add(p12);

            s1.Employees.Add(e1);
            s2.Employees.Add(e2);
            s1.Employees.Add(e3);
            s2.Employees.Add(e4);
            s3.Employees.Add(e5);
            s3.Employees.Add(e6);
            s3.Employees.Add(e7);
            s3.Employees.Add(e8);
            s3.Employees.Add(e9);
            s1.Employees.Add(e10);
            s1.Employees.Add(e11);
            s1.Employees.Add(e12);
            s1.Employees.Add(e13);
            s2.Employees.Add(e14);
            s3.Employees.Add(e15);
            s2.Employees.Add(e16);
            s3.Employees.Add(e17);
            s3.Employees.Add(e18);
            s1.Employees.Add(e19);
            s2.Employees.Add(e20);


            context.Shops.AddOrUpdate(s1, s2, s3);

            context.Products.AddOrUpdate(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);




            base.Seed(context);
        }

    }


}

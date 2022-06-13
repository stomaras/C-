namespace WebApplication6mvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication6mvc.Models;
    using Models.Enums;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication6mvc.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication6mvc.Data.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var employees = new List<Employee>
            {
                new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece },
                new Employee() { FirstName = "Agathi", LastName = "Tomara", Age = 22, HireDate = new DateTime(1999, 11, 01), Country = Country.France },
                new Employee() { FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, HireDate = new DateTime(2000, 10, 13), Country = Country.Spain },
                new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Malta },
            };

            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();

        }
    }
}




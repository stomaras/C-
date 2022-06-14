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
            #region Seeding Employees
            var employees = new List<Employee>
            {
                new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece },
                new Employee() { FirstName = "Agathi", LastName = "Tomara", Age = 22, HireDate = new DateTime(1999, 11, 01), Country = Country.France },
                new Employee() { FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, HireDate = new DateTime(2000, 10, 13), Country = Country.Spain },
                new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Malta },
            };
            #endregion

            #region Seeding Projects
            Project p1 = new Project() { Title = "Java" };
            Project p2 = new Project() { Title = "Python" };
            Project p3 = new Project() { Title = "Javascript" };
            Project p4 = new Project() { Title = "C#" };
            #endregion


            #region Aggregation Employees With Projects
            employees[0].Project = p1;
            employees[1].Project = p2;
            employees[2].Project = p3;
            employees[3].Project = p4;

            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();
            #endregion


        }
    }
}




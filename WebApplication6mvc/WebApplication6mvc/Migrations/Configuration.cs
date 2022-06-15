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
                new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age = 24, HireDate = new DateTime(2021, 11, 01), Country = Country.Greece },
                new Employee() { FirstName = "Agathi", LastName = "Tomara", Age = 22, HireDate = new DateTime(2015, 11, 01), Country = Country.France },
                new Employee() { FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, HireDate = new DateTime(2000, 10, 13), Country = Country.Spain },
                new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age = 24, HireDate = new DateTime(2019, 11, 01), Country = Country.Greece },
                new Employee() { FirstName = "Eleni", LastName = "Kallifoni", Age = 54, HireDate = new DateTime(1997, 11, 01), Country = Country.Malta },
                new Employee() { FirstName = "Stathis", LastName = "Tomaras", Age = 68, HireDate = new DateTime(1997, 11, 01), Country = Country.France },
                new Employee() { FirstName = "Xristoforos", LastName = "Kallifonis", Age = 27, HireDate = new DateTime(1995, 11, 01), Country = Country.France },
                new Employee() { FirstName = "Fillipos", LastName = "Tomaras", Age = 20, HireDate = new DateTime(2021, 11, 01), Country = Country.Malta },
                new Employee() { FirstName = "Nikos", LastName = "Papanikos", Age = 30, HireDate = new DateTime(2017, 11, 01), Country = Country.Greece },
                new Employee() { FirstName = "Ester", LastName = "Exposito", Age = 22, HireDate = new DateTime(2020, 11, 01), Country = Country.Portugal },
            };
            #endregion

            #region Seeding Projects
            Project p1 = new Project() { Title = "Java" };
            Project p2 = new Project() { Title = "Python" };
            Project p3 = new Project() { Title = "Javascript" };
            Project p4 = new Project() { Title = "C#" };
            Project p5 = new Project() { Title = "SQL" };
            Project p6 = new Project() { Title = "CSS" };
            Project p7 = new Project() { Title = "HTML5" };
            Project p8 = new Project() { Title = "JQUERY" };
            Project p9 = new Project() { Title = "React" };
            Project p10 = new Project() { Title = "ASP.NET" };
            #endregion


            #region Aggregation Employees With Projects
            employees[0].Project = p1;
            employees[1].Project = p2;
            employees[2].Project = p3;
            employees[3].Project = p4;
            employees[4].Project = p5;
            employees[5].Project = p6;
            employees[6].Project = p7;
            employees[7].Project = p8;
            employees[8].Project = p9;
            employees[9].Project = p10;

            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();
            #endregion


        }
    }
}




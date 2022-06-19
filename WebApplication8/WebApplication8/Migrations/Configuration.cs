namespace WebApplication8.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication8.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication8.MyDatabase.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication8.MyDatabase.ApplicationContext context)
        {

            #region Seed Employees

            Employee e1 = new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age=24, HireDate=new DateTime(2022,10,01), Salary=900, Country = Country.Greece, Managers = new List<Manager>() { } };
            Employee e2 = new Employee() { FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Greece, Managers = new List<Manager>() { } };
            Employee e3 = new Employee() { FirstName = "Yiannis", LastName = "Karakasis", Age = 23, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.France, Managers = new List<Manager>() { } };
            Employee e4 = new Employee() { FirstName = "Xristoforos", LastName = "Kallifonis", Age = 28, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Italy, Managers = new List<Manager>() { } };
            Employee e5 = new Employee() { FirstName = "Agathi", LastName = "Tomara", Age = 29, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Portugal, Managers = new List<Manager>() { } };
            Employee e6 = new Employee() { FirstName = "Natalia", LastName = "Kallifoni", Age = 23, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Spain, Managers = new List<Manager>() { } };
            Employee e7 = new Employee() { FirstName = "Nikos", LastName = "Papanikolas", Age = 37, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Spain, Managers = new List<Manager>() { } };
            Employee e8 = new Employee() { FirstName = "Stathis", LastName = "Tomaras", Age = 67, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Malta, Managers = new List<Manager>() { } };
            Employee e9 = new Employee() { FirstName = "Eleni", LastName = "Kallifoni", Age = 44, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Greece, Managers = new List<Manager>() { } };
            Employee e10 = new Employee() { FirstName = "Sotiris", LastName = "Kallifonis", Age = 55, HireDate = new DateTime(2022, 10, 01), Salary = 900, Country = Country.Portugal, Managers = new List<Manager>() { } };
            Employee e11 = new Employee() { FirstName = "Giorgos", LastName = "Kallifonis", Age = 58, HireDate = new DateTime(2022, 10, 01), Salary = 900, Country = Country.Portugal, Managers = new List<Manager>() { } };
            Employee e12 = new Employee() { FirstName = "Yannis", LastName = "Kallifonis", Age = 59, HireDate = new DateTime(2022, 10, 01), Salary = 900, Country = Country.Portugal, Managers = new List<Manager>() { } };

           

            #endregion



            #region Seed Projects

            Project p1 = new Project() { Title = "Java" };
            Project p2 = new Project() { Title = "C#" };
            Project p3 = new Project() { Title = "Javascript" };
            Project p4 = new Project() { Title = "Python" };
            Project p5 = new Project() { Title = "Sql" };
            Project p6 = new Project() { Title = "CSS" };

            context.Projects.AddOrUpdate(x => x.Title, p1, p2, p3, p4 ,p5, p6);
            context.SaveChanges();

            #endregion

            #region Seed Managers
            var managers = new List<Manager>
            {
                new Manager() { FirstName = "Hector", LastName = "Gatsos", Employees = new List<Employee>(){e1,e2,e3,e4 } },
                new Manager() { FirstName = "George", LastName = "Pasparakis", Employees = new List<Employee>() {e5,e6,e2 } },
                new Manager() { FirstName = "Periklis", LastName = "Aidinopoylos", Employees = new List<Employee>(){e7,e8,e3 } },
                new Manager() { FirstName = "Panos", LastName = "Bozas", Employees = new List<Employee>(){e9, e3 } },
                new Manager() {FirstName = "Nikos", LastName = "Papanikos", Employees = new List<Employee>(){} },
                new Manager() {FirstName = "Vrasidas", LastName = "Papanikos", Employees = new List<Employee>(){} },
            };

            context.Managers.AddOrUpdate(x => new { x.FirstName, x.LastName }, managers[0], managers[1], managers[2], managers[3], managers[4], managers[5]);
            context.SaveChanges();

            #endregion


            #region Aggregation Employees with Projects with Managers

            e1.Project = p1;
            e2.Project = p2;
            e3.Project = p3;
            e4.Project = p4;
            e5.Project = p1;
            e6.Project = p1;
            e7.Project = p2;
            e8.Project = p3;
            e9.Project = p4;

            e1.Managers.Add(managers[0]);
            e2.Managers.Add(managers[0]);
            e3.Managers.Add(managers[1]);
            e4.Managers.Add(managers[1]);
            e5.Managers.Add(managers[2]);
            e6.Managers.Add(managers[3]);
            e7.Managers.Add(managers[3]);
            e8.Managers.Add(managers[0]);
            e9.Managers.Add(managers[1]);
            e10.Managers.Add(managers[1]);
            e11.Managers.Add(managers[3]);
            e12.Managers.Add(managers[0]);


            context.Employees.AddOrUpdate(x => new { x.FirstName, x.LastName }, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12);
            context.SaveChanges();

            #endregion

            

           



           


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

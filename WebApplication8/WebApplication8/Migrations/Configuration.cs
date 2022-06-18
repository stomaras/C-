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

            Employee e1 = new Employee() { FirstName = "Spyros", LastName = "Tomaras", Age=24, HireDate=new DateTime(2022,10,01), Salary=900, Country = Country.Greece };
            Employee e2 = new Employee() { FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Greece };
            Employee e3 = new Employee() { FirstName = "Yiannis", LastName = "Karakasis", Age = 23, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.France };
            Employee e4 = new Employee() { FirstName = "Xristoforos", LastName = "Kallifonis", Age = 28, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Italy };
            Employee e5 = new Employee() { FirstName = "Agathi", LastName = "Tomara", Age = 29, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Portugal };
            Employee e6 = new Employee() { FirstName = "Natalia", LastName = "Kallifoni", Age = 23, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Spain };
            Employee e7 = new Employee() { FirstName = "Nikos", LastName = "Papanikolas", Age = 37, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Spain };
            Employee e8 = new Employee() { FirstName = "Stathis", LastName = "Tomaras", Age = 67, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Malta };
            Employee e9 = new Employee() { FirstName = "Eleni", LastName = "Kallifoni", Age = 44, HireDate = new DateTime(2021, 10, 01), Salary = 900, Country = Country.Greece };
            Employee e10 = new Employee() { FirstName = "Sotiris", LastName = "Kallifonis", Age = 55, HireDate = new DateTime(2022, 10, 01), Salary = 900, Country = Country.Portugal };
            Employee e11 = new Employee() { FirstName = "Giorgos", LastName = "Kallifonis", Age = 58, HireDate = new DateTime(2022, 10, 01), Salary = 900, Country = Country.Portugal };
            Employee e12 = new Employee() { FirstName = "Yannis", LastName = "Kallifonis", Age = 59, HireDate = new DateTime(2022, 10, 01), Salary = 900, Country = Country.Portugal };

           

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


            #region Aggregation Employees with Projects

            e1.Project = p1;
            e2.Project = p2;
            e3.Project = p3;
            e4.Project = p4;
            e5.Project = p1;
            e6.Project = p1;
            e7.Project = p2;
            e8.Project = p3;
            e9.Project = p4;


            context.Employees.AddOrUpdate(x => new { x.FirstName, x.LastName }, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12);
            context.SaveChanges();

            #endregion

            #region Seed Managers
            //Manager m1 = new Manager() { Name = "Gkatsos" };
            //Manager m2 = new Manager() { Name = "Pasparakis" };
            //Manager m3 = new Manager() { Name = "Aidinopoylos" };
            //Manager m4 = new Manager() { Name = "Bozas" };

            //context.Managers.AddOrUpdate(x => new { x.Name }, m1, m2, m3, m4);
            //context.SaveChanges();
            #endregion




            #region Aggregation Employees with Managers

            //e1.Managers = new List<Manager>() { m1, m2 };
            //e2.Managers = new List<Manager>() { m2, m3 };
            //e3.Managers = new List<Manager>() { m3, m4 };
            //e4.Managers = new List<Manager>() { m4 };
            //e5.Managers = new List<Manager>() { m1 };
            //e6.Managers = new List<Manager>() { m2 };
            //e7.Managers = new List<Manager>() { m3 };
            //e8.Managers = new List<Manager>() { m2 };
            //e9.Managers = new List <Manager>() { m2 };

            //m1.Employees = new List<Employee>() { e1, e5 };
            //m2.Employees = new List<Employee>() { e1, e2, e6, e8, e9 };
            //m3.Employees = new List<Employee>() { e2, e3 };

            #endregion



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

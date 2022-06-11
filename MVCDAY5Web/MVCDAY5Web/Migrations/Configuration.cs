namespace MVCDAY5Web.Migrations
{
    using MVCDAY5Web.Models;
    using MVCDAY5Web.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDAY5Web.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCDAY5Web.Data.ApplicationContext context)
        {

            var employees = new List<Employee>()
            {
                new Employee() { FirstName = "Charly", LastName = "Jordan", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece, Photo = "https://static.independent.co.uk/2020/09/08/12/newFile-11.jpg?width=1200" },
                new Employee() { FirstName = "Pamela", LastName = "Jordan", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece, Photo = "https://static.independent.co.uk/2020/09/08/12/newFile-11.jpg?width=1200" },
                new Employee() { FirstName = "Natalia", LastName = "Jordan", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece, Photo = "https://static.independent.co.uk/2020/09/08/12/newFile-11.jpg?width=1200" }
            };

            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();



       

            
         
            
        }
    }
}

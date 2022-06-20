using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCDAY5Web.Models;
using System.Data.Entity.Migrations;
using MVCDAY5Web.Models.Enums;

namespace MVCDAY5Web.Data.Initializers
{
    public class MockupDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {

            #region Employee Seeding
            var employees = new List<Employee>()
            {
                new Employee() { FirstName = "Charly", LastName = "Jordan", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece, Photo = "https://static.independent.co.uk/2020/09/08/12/newFile-11.jpg?width=1200" },
                new Employee() { FirstName = "Pamela", LastName = "Jordan", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece, Photo = "https://static.independent.co.uk/2020/09/08/12/newFile-11.jpg?width=1200" },
                new Employee() { FirstName = "Natalia", LastName = "Jordan", Age = 24, HireDate = new DateTime(1997, 11, 01), Country = Country.Greece, Photo = "https://static.independent.co.uk/2020/09/08/12/newFile-11.jpg?width=1200" }
            };


            #endregion

            #region Project Seeding

            Project p1 = new Project() { Title = "C#" };
            Project p2 = new Project() { Title = "Java" };
            Project p3 = new Project() { Title = "Python" };




            #endregion

            #region Aggregation Employee With Project
            employees[0].Project = p1;
            employees[1].Project = p2;
            employees[2].Project = p3;

            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();
            #endregion

            base.Seed(context);
        }
    }
}
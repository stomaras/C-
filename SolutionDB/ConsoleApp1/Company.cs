using MyDatabase;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Company
    {

        public void Start()
        {
            //MyDBContext dBContext = new MyDBContext();
            //UnitOfWork CompanyUnit = new UnitOfWork(dBContext);

            //var employees = CompanyUnit.Employees.EmployeesWithProjects();

            //foreach (var employee in employees)
            //{

            //    if (employee.Project == null)
            //    {
            //        string projectName = "No Project Yet";
            //        Console.WriteLine($"Employee with first name {employee.FirstName}, with last name {employee.LastName}, with project name {projectName}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Employee with first name {employee.FirstName}, with last name {employee.LastName}, with project name {employee.Project.ProjectName}");

            //    }
            //}
        }
    }
}

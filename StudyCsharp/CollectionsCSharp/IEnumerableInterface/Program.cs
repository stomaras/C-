using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            Organization organization = new Organization();


            organization.Add(new Employee { Id = 101, Name = "Tom", Job = "Software Engineer", Salary = 1000.00 });
            organization.Add(new Employee { Id = 102, Name = "Chris", Job = "Doctor", Salary = 2000.00 });
            organization.Add(new Employee { Id = 103, Name = "Kostas", Job = "Worker", Salary = 600.00 });


            foreach (Employee Emp in organization)
            {
                Console.WriteLine(Emp.Id + " " + Emp.Name + " " + Emp.Job + " " + Emp.Salary);
            }
        }
    }
}

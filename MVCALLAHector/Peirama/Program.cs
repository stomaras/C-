using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peirama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { Name = "Hector" };
            Employee e2 = new Employee() { Name = "Hector" };
            Employee e3 = new Employee() { Name = "Hector" };

            List<Employee> employees = new List<Employee> { e1, e2, e3 };

            Method(employees);
            foreach (var item in employees)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void Method(List<Employee> employees)
        {
            employees = employees.Where(e => e.Name == "Hector").ToList();
        }
    }

    class Employee
    {
        public string Name { get; set; }
    }
}

using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View.EmployeeView
{
    public class PrintEmployee : IPrintEmployee
    {
        public void ShowEmployees(IEnumerable<Employee> employees)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employees:\n");
            foreach (var employee in employees)
            {
                Console.WriteLine($"\t\tEmployee {{ with First Name {employee.FirstName}, with Last Name {employee.LastName} }}");
            }
            Console.ResetColor();

        }
    }
}

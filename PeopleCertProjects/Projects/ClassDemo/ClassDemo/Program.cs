using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Program
    {
        public static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            Employee tom = new Employee();// tom is an Object of class Employee
            Employee natalia = new Employee(); // natalia is an instance of class People
            employees.Add(tom);
            employees.Add(natalia);

            Console.WriteLine();

            //tom.SetAge(24);
            //natalia.SetAge(24);
            tom.Age = 24;
            tom.Name = "Spyros";
            tom.PhoneNumber = "6980863730";
            tom.Salary = 900;
            tom.StartingDate = new DateTime(1997, 11, 1);
            natalia.Age = 24;
            natalia.Name = "Natalia";
            natalia.PhoneNumber = "6973057110";
            natalia.Salary = 800;
            natalia.StartingDate = new DateTime(1997, 02, 24);

            // Initialization
            Employee agathi = new Employee // call to default constructor
            {
                Age = 22,
                Name = "Agathi",
                PhoneNumber = "210-4105196",
                Salary = 877.0,
                StartingDate = new DateTime(2014, 5, 16)
            };
            employees.Add(agathi);
            

            Console.WriteLine($"Tom Age is: {tom.Age}");
            Console.WriteLine($"Natalia Age is: {natalia.Age}");
            Console.WriteLine($"Tom Name is: {tom.Name}");
            Console.WriteLine($"Natalia Name is: {natalia.Name}");
            Console.WriteLine($"Agathi Name is: {agathi.Name} and his age is {agathi.Age}" +
                $"he earns {agathi.Salary} and started working {agathi.StartingDate}");

            double salaryDiff = agathi.TakeBonusReturnSalaryDiff(0.1);
            Console.WriteLine($"Agathi Name is: {agathi.Name} and his age is {agathi.Age}" +
                $"he earns {agathi.Salary} and started working {agathi.StartingDate} with difference of salary" +
                $"{salaryDiff}");

            Console.WriteLine("\n");
            Console.WriteLine("List With Employees Before Bonus:\n");
            IterateListWithEmployees(employees);
            Console.WriteLine("\n");
            ListWithEmployees(employees);
            Console.WriteLine("\n");
            Console.WriteLine("List With Employees after Bonus:\n");
            IterateListWithEmployees(employees);

            Employee spyros = new Employee(24, new DateTime(1997, 11, 01), "6973057110", "Spyros", 800.00);


        }

        public static void ListWithEmployees(List<Employee> employees)
        {
            for(int i=0; i<employees.Count; i++)
            {
                employees[i].TakeBonusReturnSalaryDiff(0.3);
            }
        }

        public static void IterateListWithEmployees(List<Employee> employees)
        {
            for(int i=0; i<employees.Count; i++)
            {
                Console.WriteLine($"Employee Name is : {employees[i].Name}, Age is : {employees[i].Age}, Phone Number is : {employees[i].PhoneNumber}, Salary is: {employees[i].Salary} ");
            }
        }
    }
}

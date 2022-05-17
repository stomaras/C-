using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Models;
using ChocolateIndustry.Repository;
using ChocolateIndustry.Interfaces;

namespace ChocolateIndustry.Services
{
    class PrintService
    {

        public static void PrintChocolates(List<IChocolate> chocolates)
        {
            foreach (IChocolate chocolate in chocolates)
            {
                Console.WriteLine(chocolate);
            }
        }

        public static void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        public static void PrintFactories(List<Factory> factories)
        {
            foreach (Factory factory in factories)
            {
                Console.WriteLine(factory);
            }
        }

        public static void PrintProgramOptions()
        {
            Console.WriteLine("Available Options:\n");
            Console.WriteLine("\t\t\tEnter 1: to enter number of Chocolates\n");
            Console.WriteLine("\t\t\tEnter 2: to enter numbers of Factories\n");
            Console.WriteLine("\t\t\tEnter 3: to enter number of Employees\n");
            Console.WriteLine("\t\t\tBEnter -1: to exit the program\n");
        }
    }
}

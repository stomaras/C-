﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View.EmployeeView
{
    public class PrintEmployee : IPrintEmployee
    {
        

        public void EnterIdToSeeDetails()
        {
            Console.WriteLine($"Enter Employee ID to see details:\n");
        }

        public void ShowEmployeeDetails(Employee employee)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Employee Details : \n");
            Console.WriteLine($"\t\tPersonal Infos:  First Name {employee.FirstName} , Last Name {employee.LastName}\n");
            if (employee.Project is null)
            {
                Console.WriteLine("\t\tProject :  No Project");
            }
            else
            {
                Console.WriteLine($"\t\tProject : {employee.Project.ProjectName} ");
            }
            if (employee.Managers.Count == 0)
            {
                Console.WriteLine("\t\tManagers : No Managers");
            }
            else
            {
                Console.WriteLine("\t\tManagers:\n");
                foreach (var manager in employee.Managers)
                {
                    Console.WriteLine($"\t\t\t\tManager : {manager.FirstName} {manager.LastName}\n");
                }
            }
            Console.ResetColor();
        }

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

        public void ShowEmployeesPerProject(IEnumerable<Employee> employees)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employees:\n");
            foreach (var employee in employees)
            {
                if (employee.Project == null)
                {
                    string Noproject = "No Project";
                    Console.WriteLine($"\t\tEmployee {{ with First Name {employee.FirstName}, with Last Name {employee.LastName}, with project {Noproject}}}");
                }
                else
                {
                    Console.WriteLine($"\t\tEmployee {{ with First Name {employee.FirstName}, with Last Name {employee.LastName}, with project {employee.Project.ProjectName}}}");

                }
            }
            Console.ResetColor();
        }

        public void ShowEmployeesPerProjectPerManager(IEnumerable<Employee> employees)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employees:\n");
            foreach (var employee in employees)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (employee.Project == null)
                {
                    string Noproject = "No Project";
                    Console.WriteLine($"\t\tEmployee {{ with First Name {employee.FirstName}, with Last Name {employee.LastName}, with project {Noproject}}}");
                }
                else
                {
                    Console.WriteLine($"\t\tEmployee {{ with First Name {employee.FirstName}, with Last Name {employee.LastName}, with project {employee.Project.ProjectName}}}");

                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\t\t\tManagers:\n");
              
                if (employee.Managers.Count == 0)
                {
                    string noManager = "No Manager Yet";
                    Console.WriteLine($"\t\t\t\t\t Manager {{ {noManager} }}");
                }
                else
                {
                    foreach (var manager in employee.Managers)
                    {
                        Console.WriteLine($"\t\t\t\t\tManager {{ First Name : {manager.FirstName}, Last Name : {manager.LastName} }}");
                    }
                }
                Console.ResetColor();
            }
        }
    }
}

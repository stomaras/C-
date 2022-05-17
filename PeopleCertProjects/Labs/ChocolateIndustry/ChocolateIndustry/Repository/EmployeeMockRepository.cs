using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Models;

namespace ChocolateIndustry.Repository
{
    class EmployeeMockRepository
    {

        public static List<Employee> AddEmployees(int numOfEmployees)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < numOfEmployees-1; i++)
            {
                Employee employee = new Employee();
                employees.Add(employee);
            }
            return employees;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Models;

namespace ChocolateIndustry.Interfaces
{
    interface IBusiness
    {
        void AddEmployee(List<Employee> employees,Employee employee);
        void RemoveEmployee(List<Employee> employees,Employee employee);
    }
}

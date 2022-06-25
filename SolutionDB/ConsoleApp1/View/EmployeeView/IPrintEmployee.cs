using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View.EmployeeView
{
    interface IPrintEmployee
    {
        void ShowEmployees(IEnumerable<Employee> employees);
    }
}

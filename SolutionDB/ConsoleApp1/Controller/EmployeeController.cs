using ConsoleApp1.View.EmployeeView;
using MyDatabase;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class EmployeeController
    {

        public static MyDBContext catalogos = new MyDBContext();
        UnitOfWork companyUnit = new UnitOfWork(catalogos);

        public void ReadEmployees()
        {
            try
            {
                var employees = companyUnit.Employees.GetAll();
                PrintEmployee printEmployee = new PrintEmployee();
                printEmployee.ShowEmployees(employees);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

        public void ErrorService()
        {
            Console.WriteLine("Error service");
        }
    }
}

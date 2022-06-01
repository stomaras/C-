using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository();

            // Read
            var employees = rep.ReadEmployees();
            Print.AllEmployees(employees);

            // Create
            Console.WriteLine("Give employees Name:\n");
            string name = Console.ReadLine();
            rep.CreateEmployee(name);

        }

        
    }

    class Repository : IRpository
    {
        //public List<Employee> GetEmployees()
        //{
        //    // Here will come all Employees
        //    throw new NotImplementedException();
        //}

        //public void CreateEmployee(string name)
        //{
        //    // Here i create an employee and save in database
        //    throw new NotImplementedException("Create Employee does not have implemented");
        //}

        //public void EditEmployee(int id, string name)
        //{
        //    // Here i will do edit employee with the above mentioned id and will give him a new name
        //    throw new NotImplementedException();
        //}

        //public void DeleteEmployee(int id)
        //{
        //    // i will make delete Employee
        //    throw new NotImplementedException("Delete Employee");
        //}
        public void CreateEmployee(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(int id, string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> ReadEmployees()
        {
            throw new NotImplementedException();
        }
    }

    // Print such as Library
    // Seperation Of Concerns 
    static class Print
    {
        // will print all Employees
        public static void AllEmployees(List<Employee> employees)
        {
            // Here will printing employees
            throw new NotImplementedException();
        }

        public static void Employee(Employee emp)
        {
            // here will print employee
            throw new NotImplementedException();
        }
    } 

    /*
     * Senior create all these IRepository
     * 
     * 
     */
    interface IRpository
    {
        void CreateEmployee(string name);
        List<Employee> ReadEmployees();
        void EditEmployee(int id, string name);
        void DeleteEmployee(int id);
        
    }

}

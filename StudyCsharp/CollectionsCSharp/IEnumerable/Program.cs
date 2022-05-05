using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    /*
     * IEnumerable Interface : most important thing , with which forEach Loop Works
     * 
     * -IEnumerable
     *  -ICollection
     *      -IList
     *      -IDictionary
     * 
     * List 
     * 
     * forEach Loop Works because every collection inherits from IEnumerable Interface, this IEnumerable inside contains a method called getEnumerator()
     * and this getEnumerator used from forEach Loop for printing 
     * 
     * public Enumerator GetEnumerator(); inside List class ---> if this method is not available, then foeEach Loop is not going to work
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            Organization organization = new Organization();


            organization.Add(new Employee { Id = 101, Name = "Tom", Job = "Software Engineer", Salary = 1000.00 });
            organization.Add(new Employee { Id = 102, Name = "Chris", Job = "Doctor", Salary = 2000.00 });
            organization.Add(new Employee { Id = 103, Name = "Kostas", Job = "Worker", Salary = 600.00 });


            foreach (Employee Emp in organization)
            {
                Console.WriteLine(Emp.Id + " " + Emp.Name + " " + Emp.Job + " " + Emp.Salary);
            }
        }
    }
}

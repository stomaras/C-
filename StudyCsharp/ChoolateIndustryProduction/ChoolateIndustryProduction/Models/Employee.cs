using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoolateIndustryProduction.Models
{
    class Employee
    {
        public static int Employee_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public Employee(string FirstName, string LastName, decimal Salary)
        {
            GenerateEmployee_ID();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
        }

        public static void GenerateEmployee_ID()
        {
            Employee_ID++;
        }

        public override string ToString()
        {
            return $"Employee {{ First Name {FirstName}, Last Name {LastName}, Salary {Salary}}}";
        }
    }
}

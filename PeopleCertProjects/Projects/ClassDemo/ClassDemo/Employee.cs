using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    
    class Employee
    {
        public int Age { get; set; } // Simple Property
        public DateTime StartingDate { get; set; }
        public String PhoneNumber { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }
        // encapsulation, data hiding
        /*
         * 
         * private int age; // field holds data
        public int Age // property
        {
            get 
            { 
                return age; 
            }

            set
            {
                age = value;
            }
        }
         */

        public double TakeBonusReturnSalaryDiff(double bonusPercent)
        {
            double newSalary = Salary + (Salary * bonusPercent);
            //Salary += Salary * bonusPercent;
            double salaryDiff = newSalary - Salary;
            Salary = newSalary;
            return salaryDiff;
        }



    }
}

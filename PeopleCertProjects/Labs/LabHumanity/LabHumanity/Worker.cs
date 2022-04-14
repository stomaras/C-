using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHumanity
{
    class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double WeekSalary { get; set; }
        public int HoursPerDay { get; set; }
        public double SalaryPerHour { get; set; }

        public Worker(string firstName, string lastName, double weekSalary, int hoursPerDay, double salaryPerHour)
        {
            FirstName = firstName;
            LastName = lastName;
            WeekSalary = weekSalary;
            HoursPerDay = hoursPerDay;
            SalaryPerHour = salaryPerHour;
        }

        public override string ToString()
        {
            String workerInfo = $"First Name : {FirstName}\n Last Name : {LastName}\n Week Salary : {WeekSalary}\n Hours Per Day : {HoursPerDay}\n Salary Per Hour : {SalaryPerHour}";
            return workerInfo;
        }



    }
}

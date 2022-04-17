using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHumanity
{
    class Worker
    {

        private string FirstName { get; set; } // the firstName property
        private string LastName { get; set; }
        private double WeekSalary { get; set; }
        private int HoursPerDay { get; set; }
        private double SalaryPerHour { get; set; }

        public List<Worker> workers = new List<Worker>();

        public Worker(string firstName, string lastName, double weekSalary, int hoursPerDay, double salaryPerHour)
        {

            checkFirstNameCharAndLength(firstName);
            checkLastNameCharAndLength(lastName);
            checkWeekSalary(weekSalary);
            checkWorkingHours(hoursPerDay);
            SalaryPerHour = salaryPerHour;
        }

        public void checkFirstNameCharAndLength(string firstName)
        {
               if (firstName.Length > 2 && char.IsUpper(firstName[0]))
               {
                   FirstName = firstName;
               }
               else
               {

                do
                {
                    Console.WriteLine("First Name must be at least 2 characters long and first Letter must be Upper Case");
                    string first = Console.ReadLine();
                    firstName = first;

                } while (firstName.Length < 2 || !char.IsUpper(firstName[0]));
                FirstName = firstName;
               } 
        }

        public void checkLastNameCharAndLength(string lastName)
        {
            if (lastName.Length > 2 && char.IsUpper(lastName[0]))
            {
                LastName = lastName;
            }
            else
            {

                do
                {
                    Console.WriteLine("Last Name must be at least 3 characters long and first Letter must be Upper Case");
                    string first = Console.ReadLine();
                    lastName = first;

                } while (lastName.Length < 3 || !char.IsUpper(lastName[0]));
                LastName = lastName;
            }
        }

        public void checkWeekSalary(double weekSalary)
        {
            if(weekSalary > 10.00)
            {
                WeekSalary = weekSalary;
            } else
            {
                do
                {
                    Console.WriteLine("Week Salary must be at least 10.00$");
                    double Salary = double.Parse(Console.ReadLine());
                    weekSalary = Salary;
                } while (weekSalary < 10.00);
                WeekSalary = weekSalary;
            }
        }

        public void checkWorkingHours(int workingHours)
        {
            if(workingHours >=1 && workingHours <= 12)
            {
                HoursPerDay = workingHours;
            }
            else
            {
                do
                {
                    Console.WriteLine("Working Hours must be among 1 and 12 hours per day");
                    int hours = int.Parse(Console.ReadLine());
                    workingHours = hours;
                } while (workingHours < 1 || workingHours > 12);
                HoursPerDay = workingHours;
            }
        }

        public static void IterateWorkerList(List<Worker> workers)
        {
            for(int i=0; i<workers.Count; i++)
            {
                Console.WriteLine($"Worker : {i} : {workers[i]}\n");
            }
        }

        public static int HowManyWorkers(List<Worker> workers)
        {
            return workers.Count;
        }

        public override string ToString()
        {
            String workerInfo = $"First Name : {FirstName}\n Last Name : {LastName}\n Week Salary : {Math.Round(WeekSalary,2)}\n Hours Per Day : {HoursPerDay}\n Salary Per Hour : {Math.Round(SalaryPerHour,2)}";
            return workerInfo;
        }



    }
}

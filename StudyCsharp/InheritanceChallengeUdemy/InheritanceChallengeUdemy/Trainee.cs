using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallengeUdemy
{
    class Trainee : Employee
    {

        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string firstName, string lastName, int salary) :base(firstName, lastName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", SchoolHours);
        }

        public void Work()
        {
            Console.WriteLine("I'm work for {0} hours", WorkingHours);
        }
    }
}

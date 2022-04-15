using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallengeUdemy
{
    class Bosses : Employee
    {
        public string CompanyCar { get; set; }

        public Bosses(string companyCar, string firstName, string lastName, int salary):base(firstName, lastName, salary)
        {
            this.CompanyCar = companyCar;

        }

        public void Lead()
        {
            Console.WriteLine("I'm boss! My name is : {0} {1}", FirstName, LastName);
        }

        
    }
}

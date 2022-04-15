using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallengeUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Tom", 4000);
            michael.Work();
            michael.Pause();

            Bosses leader = new Bosses("Porsche", "Spyros", "Tomy", 850);
            leader.Lead();

            Trainee tom = new Trainee(12, 6, "Spyros", "Tomaras", 1000);
            tom.Work();
            tom.Learn();

            Console.ReadKey();
        }
    }
}

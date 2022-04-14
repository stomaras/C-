using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        public static string behaviour;
        static void Main(string[] args)
        {

            CreditCard creditCardTom = new CreditCard("Spyros Tomaras", "69840181", true, new DateTime(2025, 01, 11));
            String creditCard = creditCardTom.ToString();
            Console.WriteLine(creditCard);
            Console.WriteLine("\n");
            Student student = new Student("Spyros", "Tomaras", 24, 1.80, 1.000, new DateTime(1997, 01, 11), "6980863730" ,creditCardTom);
            String studentTom = student.ToString();
            Console.WriteLine(studentTom.ToString());
            Console.WriteLine("\n");
            Country country = new Country("Greece");
            country.addStudent(student);
            String greece = country.ToString();
            Console.WriteLine(greece);

            
            do
            {
                Console.WriteLine("Enter a tuition for the student: Good (or) Poor (or) Excellent");
                behaviour = Console.ReadLine();
            } while (behaviour != "Good" && behaviour != "Poor" && behaviour != "Excellent");
            student.AffectConductInTuition(behaviour);
            Console.WriteLine(greece);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// More advanced shuffle / RNGCryptoServceProvider Demo:


namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.NextDouble() * 10);
            //    //SimpleMethod(random);
            // Guids maybe unique but nor neccessary random
            //
            //}
            List<PersonModel> people = new List<PersonModel>()
            {
                new PersonModel{FirstName = "Tim"},
                new PersonModel{FirstName = "Sue"},
                new PersonModel{FirstName = "Mary"},
                new PersonModel{FirstName = "George"},
                new PersonModel{FirstName = "Jane"},
                new PersonModel{FirstName = "Nancy"},
                new PersonModel{FirstName = "Bob"}
            };

            var sortedPeople = people.OrderBy(x => random.Next());


            foreach (var p in people)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}

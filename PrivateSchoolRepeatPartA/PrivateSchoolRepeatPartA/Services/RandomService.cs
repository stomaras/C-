using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolRepeatPartA.Services
{
    class RandomService
    {

        private static Random _rand = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        /// This method generate a random number between min and max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Number(int min, int max)
        {
            int result = 0;
            result = _rand.Next(min, max);
            return (result);
        }

        /// <summary>
        /// This method generate a random first name
        /// </summary>
        /// <returns></returns>
        public static string RandFirstName()
        {
            List<string> FirstNames = new List<string>() { "Spyros", "Natalia", "Agathi", "Stathis", "Eleni", "Nafsika", "Panagiwta", "Eleana", "Apostolhs", "Xristoforos", "Giannis", "Chris", "George", "Xristos" };
            string FirstName = FirstNames[_rand.Next(0, FirstNames.Count)];
            return FirstName;

        }

        /// <summary>
        /// This method generate a random last name
        /// </summary>
        /// <returns></returns>
        public static string RandLastName()
        {
            List<string> LastNames = new List<string> { "Tomaras", "Zacharaki", "Karakasis", "Papanikolaoy", "Kallifoni", "Kakochristoy", "Fragulis", "Zarmakoupes", "Kanoulas", "Karaulanis" };
            string LastName = LastNames[_rand.Next(0, LastNames.Count)];
            return LastName;
        }

        public static string RandTrainerFirstName()
        {
            List<string> FirstNames = new List<string>() { "Kostas", "Ektor", "Periklis", "George", "Nikos", "Mark", "Panos", "Xristina" };
            string firstName = FirstNames[_rand.Next(0, FirstNames.Count)];
            return firstName;
        }

        public static string RandTrainerLastName()
        {
            List<string> LastNames = new List<string>() { "Gkatsos", "Aidinopoylos", "Pasparakis", "Irakleidis", "Zuckerberg", "Jobs", "Dorvalds", "Papamixail" };
            string lastName = LastNames[_rand.Next(0, LastNames.Count)];
            return lastName;
        }

        public static string Subject()
        {
            List<string> Subject = new List<string>() { "Java", "C#", "Python", "Javascript" };
            string subject = Subject[_rand.Next(0, Subject.Count)];
            return subject;
        }

        public static string Type()
        {
            List<string> Type = new List<string>() { "Full Time", "Part Time" };
            string type = Type[_rand.Next(9, Type.Count)];
            return type;
        }

    }
}

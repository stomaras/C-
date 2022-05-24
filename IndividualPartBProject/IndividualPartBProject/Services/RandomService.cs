using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartBProject.Services
{
    class RandomService
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);
        public static int Number(int min, int max)
        {
            int result = 0;
            result = _rand.Next(min, max);
            return (result);
        }

        public static string RandFirstName()
        {
            List<string> FirstNames = new List<string>() { "Spyros", "Natalia", "Agathi", "Stathis", "Eleni", "Nafsika", "Panagiwta", "Eleana", "Apostolhs", "Xristoforos", "Giannis", "Chris", "George", "Xristos" };
            string FirstName = FirstNames[_rand.Next(0, FirstNames.Count)];
            return FirstName;

        }

        public static string RandLastName()
        {
            List<string> LastNames = new List<string> { "Tomaras", "Zacharaki", "Karakasis", "Papanikolaoy", "Kallifoni", "Kakochristoy", "Fragulis", "Zarmakoupes", "Kanoulas", "Karaulanis" };
            string LastName = LastNames[_rand.Next(0, LastNames.Count)];
            return LastName;
        }

        public static List<string> RandAssigment()
        {
            List<string> Assigments = new List<string> { "Assigment 1", "Assigment 2", "Assigment 3", "Assigment 4", "Individual Part A", "Individual Part B", "Group Project" };
            return Assigments;
        }

        public static List<string> RandAssigmentDescription()
        {
            List<string> Descriptions = new List<string> { "Java Part Time", "C# Part Time", "Python Part Time", "Javascript Part Time", "Java Full Time", "C# Full Time", "Python Full Time", "Javascript Full Time" };
            return Descriptions;
        }
        public static int Age()
        {
            List<int> ages = new List<int>() { 44, 13, 18, 87, 90, 100, 87, 100, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 50, 61, 79, 44, 45 };
            int age = ages[_rand.Next(0, ages.Count - 1)];
            return age;
        }
    }
}

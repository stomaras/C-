using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBegin.Services
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

        public static string RandName()
        {
            List<string> FirstNames = new List<string>() { "Spyros", "Natalia", "Agathi", "Stathis", "Eleni", "Nafsika", "Panagiwta", "Eleana", "Apostolhs", "Xristoforos", "Giannis", "Chris", "George", "Xristos" };
            List<string> LastNames = new List<string> { "Tomaras", "Zacharaki", "Karakasis", "Papanikolaoy", "Kallifoni",  "Kakochristoy", "Fragulis", "Zarmakoupes", "Kanoulas"};
            Random rand = new Random(DateTime.Now.Second);
            string FirstName = FirstNames[rand.Next(0, FirstNames.Count - 1)];
            string lastName = LastNames[rand.Next(0, LastNames.Count - 1)];

            string fullName = "{" + FirstName + " " + lastName + "}";
            return fullName;

        }

        public static int Age()
        {
            List<int> ages = new List<int>() { 44, 13, 18, 87, 90, 100, 87, 100, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 50, 61, 79, 44, 45, 46, 47, 48, 49, 50 };
            int age = ages[_rand.Next(0, ages.Count - 1)];
            return age;
        }


    }
}

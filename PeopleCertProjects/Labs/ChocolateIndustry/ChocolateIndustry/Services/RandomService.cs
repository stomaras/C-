using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateIndustry.Services
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

        public static string RandName()
        {
            List<string> ChocholateNames = new List<string>() { "White", "Black", "Milk"};
            string chocolateName = ChocholateNames[_rand.Next(0, ChocholateNames.Count)];

            return chocolateName;

        }

        public static string RandFactoryName()
        {
            List<string> FactoryNames = new List<string>() { "Winter Dream", "Chcocolate Cravings", "Choco Chip", "Cocoa Bean", "Hot Cocoa Dreams", "Cocoa Treats", "Yummy Hot Chocolate" };
            string factoryName = FactoryNames[_rand.Next(0, FactoryNames.Count)];
            return factoryName;
        }

        public static int RandQualityIndex()
        {
            List<int> indexes = new List<int>() { 1, 2, 3, 4, 5 };
            int index = indexes[_rand.Next(0, indexes.Count - 1)];
            return index;
        }

        public static int Price()
        {
            List<int> prices = new List<int>() { 2, 4, 5, 6, 7, 8, 9, 10 };
            int price = prices[_rand.Next(0, prices.Count - 1)];
            return price;
        }

        public static int Age()
        {
            List<int> ages = new List<int>() { 44, 13, 18, 87, 90, 100, 87, 100, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 50, 61, 79, 44, 45 };
            int age = ages[_rand.Next(0, ages.Count - 1)];
            return age;
        }

        public static int Wages()
        {
            List<int> wages = new List<int>() { 800, 700, 730, 790, 820, 850, 900, 950, 1000, 1050, 1200, 1100, 1150, 1300, 1400, 1550, 1600, 1650, 1800, 1900, 1950, 2000, 2500, 3000, 3500, 4000, 4500, 5000 };
            int wage = wages[_rand.Next(0, wages.Count)];
            return wage;
        }
    }
}

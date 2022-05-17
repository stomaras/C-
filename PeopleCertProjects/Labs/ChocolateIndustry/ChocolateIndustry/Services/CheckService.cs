using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateIndustry.Services
{
    class CheckService
    {

        public static int EnterValidNumberBetween0And10(string s)
        {
            bool isNumber = false;
            bool isBetween0And10 = false;
            int num = -1;
            while (!isNumber && !isBetween0And10)
            {
                if (s.All(char.IsDigit))
                {

                    isNumber = true;
                    num = Convert.ToInt32(s);
                    if ((num >= 0) && (num <= 10))
                    {
                        isBetween0And10 = true;
                    }
                    else
                    {
                        Console.WriteLine("Input cannot contain numbers less than 0 or numbers bigger than 10!");
                    }
                }
                else
                {
                    Console.WriteLine("Input cannot contain characters or special characters!");
                }
                if(!isNumber || !isBetween0And10)
                {
                    Console.WriteLine("Enter number between 0 and 10:\n");
                    s = Console.ReadLine();
                }
            }
            return num;
        }
    }
}

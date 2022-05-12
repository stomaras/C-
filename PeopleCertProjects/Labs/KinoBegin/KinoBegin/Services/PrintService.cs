using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBegin.Services
{
    class PrintService
    {
        public static void InvalidNumberMessage()
        {
            Console.WriteLine("Number cannot be string must be integer between <<1-80>>");
        }

        public static void InvalidRangeNumberMessage()
        {
            Console.WriteLine("Number Must be in range <<1-80>>");
        }

        public static void IsNotUniqueUserNumber()
        {
            Console.WriteLine("Number already exists! try again");
        }

        public static void QuestionAboutKinoBonus()
        {
            Console.WriteLine("Do You Want to Play With Kino Bonus Enter: Y/N\n");
        }

        public static void EnterNumberBetween1And80()
        {
            Console.WriteLine("Enter Number between 1-80:\n");
        }

        public static void PlayerWinsKinoBonus()
        {
            Console.WriteLine("Player wins kino bonus");
        }

        public static void PlayerLostKinoBonus()
        {
            Console.WriteLine("Player lost kino bonus");
        }

       
    }
}

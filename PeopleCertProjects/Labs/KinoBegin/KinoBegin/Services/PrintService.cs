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
            Console.WriteLine("Ticket Number cannot be string must be integer between <<1-80>>");
        }

        public static void InvalidRangeNumberMessage()
        {
            Console.WriteLine("Ticket Number Must be in range <<1-80>>");
        }

        public static void IsNotUniqueUserNumber()
        {
            Console.WriteLine("Ticket Number already exists! try again");
        }

        public static void QuestionAboutKinoBonus()
        {
            Console.WriteLine("Do You Want to Play With Kino Bonus Enter: Y/N\n");
        }

        public static void EnterNumberBetween1And80()
        {
            Console.WriteLine("Enter New Ticket Number between 1-80:\n");
        }

        public static void EnterNumberOfPlayers()
        {
            Console.WriteLine("Enter Number of Players:\n");
        }

        public static void PlayersNumberMustBeBetween1And20()
        {
            Console.WriteLine("Players Number must be between <<1 and 20>>");
        }

        public static void EnterNumberBetween1And20()
        {
            Console.WriteLine("Number must be in range <<1-20>>");
        }

        //public static void EnterNumberOfTickets()
        //{
        //    Console.WriteLine("Number Of Tickets must be amont <<1-10>> tickets");
        //}

        public static string EnterNewTicketNumber()
        {
            string s = " New Ticket With Number : ";
            return s;
        }

       
    }
}

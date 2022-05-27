using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolRepeatPartA.Services
{
    class PrintService
    {

        #region Initialize Front End Variables For Console
        const int first = -50;
        const int second = -50;
        const int third = -55;
        const int fourth = -40;

        
        #endregion

        #region Chooose An Option Message

        /// <summary>
        /// This method show a start message in the Console
        /// </summary>
        public static void ChooseAnOption()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose an option");
            Console.WriteLine();
            Console.ResetColor();
        }

        #endregion

        #region Menu Options

        /// <summary>
        /// This method show all available options in the Menu
        /// </summary>
        public static void MenuOptions()
        {
            Console.WriteLine($"{"----------------ALL DATA----------------",first}{"------------------ORDERED BY---------------------",second}{"------------------Special Query---------------------",third}");
            Console.WriteLine($"{"1 - Students",first}{"5 - Students Per Course",second}{ "9 - Students that belong to more than one courses",third}");
            Console.WriteLine($"{"2 - Trainers",first}{"6 - Trainers Per Course"}", second);
            Console.WriteLine($"{"3 - Courses",first}{"7 - Assigments Per Course"}", second);
            Console.WriteLine($"{"4 - Assigments",first}{"8 - Assigments Per Student"}", second);
        }

        #endregion

        #region MessaageForEntitiesPrint

        /// <summary>
        /// This method print a standard message for each entity
        /// </summary>
        /// <param name="message"></param>
        public static void PrintMessageForEntities(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        #endregion
    }
}

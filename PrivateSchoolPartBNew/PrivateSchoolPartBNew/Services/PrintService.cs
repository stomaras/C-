using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Services
{
    class PrintService
    {
        /// <summary>
        /// 
        /// </summary>
        public static void EnterMenuOptions()
        {
            Console.WriteLine("\t\t\t-----------Menu:-----------\n");
            Console.WriteLine("\t\t|||1.Enter Student Details:|||\n");
            Console.WriteLine("\t\t|||2.Enter Trainer Details:|||\n");
            Console.WriteLine("\t\t|||3.Enter Course Details:|||\n");
            Console.WriteLine("\t\t|||4.Enter Assigment Details:|||\n");
            Console.WriteLine("\t\t|||5.Print Students:|||\n");
            Console.WriteLine("\t\t|||6.Print Trainers:|||\n");
            Console.WriteLine("\t\t|||7.Print Courses:|||\n");
            Console.WriteLine("\t\t|||8.Print Assigments:|||\n");
            Console.WriteLine("\t\t|||9.Print Students Per Course:|||\n");
            Console.WriteLine("\t\t|||10.Print Trainers Per Course:|||\n");
            Console.WriteLine("\t\t|||11.Print Assigments Per Course:|||\n");
            Console.WriteLine("\t\t|||12.Exit Program:|||\n");
            Console.WriteLine("\t\t|||Give a choice:|||\n");
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PrintTrainers()
        {
            Console.WriteLine("Trainers:\n");
            Console.WriteLine(DatabaseService.SelectTrainers());
        }
    }
}

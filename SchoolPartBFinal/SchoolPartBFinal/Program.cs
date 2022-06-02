using SchoolPartBFinal.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int first = -45;
            const int second = -50;
            const int third = -45;
            const int fourth = -50;
            string input = "";
            StudentController stController = new StudentController();
            while (input != "e" || input != "E")
            {
                Console.WriteLine();
                

                Console.WriteLine("----------------------------------------------------------------------------------------CRUD---------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"---------Create Operations---------",first}{"---------Reading Operations---------", second}{"---------Update Operations---------", third}{"---------Delete Operations---------",fourth}");
                Console.WriteLine($"{"Press 1 - Create Student",first}{"Press 2 - Read Student",second}{"Press 3 - Update Student",third}{"Press 4 - Delete Student",fourth}");
                Console.WriteLine($"{"Press 5 - Create Trainer",first}{"Press 6 - Read Trainer",second}{"Press 7 - Update Trainer",third}{"Press 8 - Delete Trainer",fourth}");
                Console.WriteLine($"{"Press 9 - Create Course",first}{"Press 10 - Read Course",second}{"Press 11 - Update Course",third}{"Press 12 - Delete Course",fourth}");
                Console.WriteLine($"{"Press 13 - Create Assigment",first}{"Press 14 - Read Assigment",second}{"Press 15 - Update Assigment",third}{"Press 16 - Delete Assigment",fourth}");


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose an option");
                Console.WriteLine();
                Console.ResetColor();
                input = Console.ReadLine();

                Console.Clear();
                switch (input)
                {
                    case "1": stController.CreateStudent();break;
                    case "2": stController.ReadingStudent(); break;
                    case "3": stController.UpdateStudent(); break;
                    case "4": stController.DeleteStudent(); break;
                    default: stController.ErrorService();break;
                }

            }
        }

         
    }
}

using SchoolPartBFinal.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPartBFinal.Enums;

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
            StudentController studentController = new StudentController();
            TrainerController trainerController = new TrainerController();
            while (input != "e" || input != "E")
            {
                Console.WriteLine();
                

                Console.WriteLine("----------------------------------------------------------------------------------------CRUD---------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"---------Create Operations---------",first}{"---------Reading Operations---------", second}{"---------Update Operations---------", third}{"---------Delete Operations---------",fourth}");
                Console.WriteLine($"{"Press 1 - Create Student",first}{"Press 2 - Read Students",second}{"Press 3 - Update Student",third}{"Press 4 - Delete Student",fourth}");
                Console.WriteLine($"{"Press 5 - Create Trainer",first}{"Press 6 - Read Trainer",second}{"Press 7 - Update Trainer",third}{"Press 8 - Delete Trainer",fourth}");
                Console.WriteLine($"{"Press 9 - Create Course",first}{"Press 10 - Read Course",second}{"Press 11 - Update Course",third}{"Press 12 - Delete Course",fourth}");
                Console.WriteLine($"{"Press 13 - Create Assigment",first}{"Press 14 - Read Assigment",second}{"Press 15 - Update Assigment",third}{"Press 16 - Delete Assigment",fourth}");
                

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose an option");
                Console.WriteLine();
                
                int inputt = Convert.ToInt32(Console.ReadLine()); // "1", "2", "3", "4"
                Console.ResetColor();
                Console.Clear();

                Choice choice = (Choice)inputt;

                switch (choice)
                {
                    case Choice.CreateStudent: studentController.CreateStudent();break;
                    case Choice.ReadStudent: studentController.ReadingStudent(); break;
                    case Choice.UpdateStudent: studentController.UpdateStudent(); break;
                    case Choice.DeleteStudent: studentController.DeleteStudent(); break;
                    case Choice.CreateTrainer: trainerController.CreateTrainer(); break;
                    case Choice.ReadTrainer: trainerController.ReadingTrainers(); break;
                    case Choice.UpdateTrainer: trainerController.UpdateTrainer(); break;
                    case Choice.DeleteTrainer: trainerController.DeleteTrainer(); break;
                    default: studentController.ErrorService();break;
                }

            }
        }

         
    }
}

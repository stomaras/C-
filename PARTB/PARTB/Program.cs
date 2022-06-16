using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARTB.Controllers;
using PARTB.Enums;

namespace PARTB
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
            AssigmentController assigmentController = new AssigmentController();
            CourseController courseController = new CourseController();
            while (input != "e" || input != "E")
            {
                Console.WriteLine();


                Console.WriteLine("----------------------------------------------------------------------------------------CRUD---------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"---------Create Operations---------",first}{"---------Reading Operations---------",second}{"---------Update Operations---------",third}{"---------Delete Operations---------",fourth}");
                Console.WriteLine($"{"Press 1 - Read Students",first}{"Press 2 - Read Trainers ",second}{"Press 3 - Read Assigments",third}{"Press 4 - Read Courses",fourth}");
                Console.WriteLine($"{"Press 5 - Read Students Per Course",first}{"Press 6 - Read Trainers Per Course",second}{"Press 7 - Read Assigments Per Course",third}{"Press 8 - Delete Trainer",fourth}");
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
                    case Choice.ReadStudents: studentController.ReadingStudents(); break;
                    case Choice.ReadTrainers: trainerController.ReadingTrainers(); break;
                    case Choice.ReadAssigments: assigmentController.ReadingAssigments(); break;
                    case Choice.ReadCourses: courseController.ReadingCourses(); break;
                    case Choice.StudentsPerCourse: courseController.ReadStudentsPerCourse();break;
                    case Choice.TrainersPerCourse: courseController.ReadTrainersPerCourse();break;
                   
                    default: studentController.ErrorService();break;
                }

            }
        }
    }
    }


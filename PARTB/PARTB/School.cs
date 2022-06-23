using PARTB.Controllers;
using PARTB.Enums;
using PARTB.Models.CustomValidations;
using PARTB.View.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB
{
    public class School
    {

        public void Start()
        {
            string input = "";

            Helper helper = new Helper();
            bool isNumber = false;

            while (input != "e" && input != "E")
            {
                Menu.ShowMenu();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose an option");
                Console.ResetColor();
                input = Console.ReadLine();
                isNumber = helper.CheckIfIsNumber(input);
                if (isNumber)
                {
                    StudentController studentController = new StudentController();
                    TrainerController trainerController = new TrainerController();
                    AssigmentController assigmentController = new AssigmentController();
                    CourseController courseController = new CourseController();

                    int inputt = Convert.ToInt32(input);
                    Console.ResetColor();
                    Console.Clear();

                    Choice choice = (Choice)inputt;

                    switch (choice)
                    {
                        case Choice.ReadStudents: studentController.ReadingStudents(); break;
                        case Choice.ReadTrainers: trainerController.ReadingTrainers(); break;
                        case Choice.ReadAssigments: assigmentController.ReadingAssigments(); break;
                        case Choice.ReadCourses: courseController.ReadingCourses(); break;
                        case Choice.StudentsPerCourse: courseController.ReadStudentsPerCourse(); break;
                        case Choice.TrainersPerCourse: courseController.ReadTrainersPerCourse(); break;
                        case Choice.AssigmentsPerStudentPerCourse:
                        case Choice.CreateStudent: studentController.CreateStudents(); break;
                        case Choice.CreateTrainer: trainerController.CreateTrainers();break;
                        case Choice.CreateCourse: courseController.CreateCourses(); break;
                        case Choice.CreateAssigment: assigmentController.CreateAssigments(); break;
                        default: studentController.ErrorService(); break;
                    }
                }
                else
                {
                    if (input != "E" && input != "e")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press a <<number>> or <<e>> or <<E>> to exit the program...");
                        Console.ResetColor();
                    }
                }
                // "1", "2", "3", "4"
            }
            Console.WriteLine("Program Ends...");
        }
    }
}

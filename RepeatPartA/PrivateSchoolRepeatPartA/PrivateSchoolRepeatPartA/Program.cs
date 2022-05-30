using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolRepeatPartA.Models;
using PrivateSchoolRepeatPartA.Services;

namespace PrivateSchoolRepeatPartA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();

            
            string input;

            do
            {
                
                PrintService.ChooseAnOption();
                PrintService.MenuOptions();
                

               input = Console.ReadLine();
                switch (input)
                {
                    case "1": View.Students(db.Students,"All Students");break;
                    case "2": View.Trainers(db.Trainers, "All Trainers");break;
                    case "3": View.Courses(db.Courses, "All Courses");break;
                    case "4": View.Assigments(db.Assigments, "All Assigments");break;
                    default:
                        break;
                }
            } while (input != "E" && input != "e");
        }
    }
    public class View
    {
        /// <summary>
        /// This method take as inputs a List of Students and an appropriate message and shows all students in private school
        /// </summary>
        /// <param name="Students"></param>
        /// <param name="message"></param>
        public static void Students(List<Student> Students, string message)
        {
            PrintService.PrintMessageForEntities(message);
            Console.WriteLine($"{"Id",-15}{"FirstName",-15}{"LastName",-15}{"DateOfBirth",-15}{"Tuition Fees", -25}");
            Console.ResetColor();
            foreach (var student in Students)
            {
                student.Print();
            }
        }


        public static void Trainers(List<Trainer> Trainers, string message)
        {
            PrintService.PrintMessageForEntities(message);
            Console.WriteLine($"{"Id",-15}{"FirstName",-15}{"LastName",-15}{"Subject",-15}");
            Console.ResetColor();
            foreach (var trainer in Trainers)
            {
                trainer.Print();
            }
        }

        public static void Courses(List<Course> Courses, string message)
        {
            PrintService.PrintMessageForEntities(message);
            Console.WriteLine($"{"Id",-15}{"Stream",-15}{"Type",-15}{"Start Date",-15}{"End Date",-15}");
            Console.ResetColor();
            foreach (var course in Courses)
            {
                course.Print();
            }
        }

        public static void Assigments(List<Assigment> Assigments, string message)
        {
            PrintService.PrintMessageForEntities(message);
            Console.WriteLine($"{"Id",-15}{"Stream",-15}{"",-15}{"Submission Date Time",-15}");
            Console.ResetColor();
            foreach (var assigment in Assigments)
            {
                assigment.Print();
            }
        }


    }

}



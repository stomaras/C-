using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolDatabasePartB.Database;

namespace SchoolDatabasePartB.Services
{
    public class PrintService
    {

        public static void PrintStudentMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();

        }

        public static void PrintTrainerMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintAssigmentMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void PrintStudent(Student student)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{student.first_name,-15}{student.last_name,-15}{student.birth_date,-15}");
            Console.ResetColor();
        }

        public static void PrintTrainer(Trainer trainer)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{trainer.first_name,-15}{trainer.last_name,-15}{trainer.subject,-15}");
            Console.ResetColor();
        }

        public static void PrintAssigment(Assigment assigment)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{assigment.title,-15}{assigment.description,-15}{assigment.subDateTime,-15}");
            Console.ResetColor();
        }
    }
}

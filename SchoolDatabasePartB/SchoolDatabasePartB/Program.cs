using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolDatabasePartB.Database;
using SchoolDatabasePartB.Views;

namespace SchoolDatabasePartB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolDatabaseEntities db = new SchoolDatabaseEntities();

            const int first = -40;
            const int second = -50;
            const int third = -40;
            const int fourth = -50;
            const int fifth = -40;
           
            string input;

            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose an option");
                Console.WriteLine();
                Console.ResetColor();

                Console.WriteLine($"{"------------ READ DATA ----------------",first}{"--------------PER-------------------",second}{"--------------------- INSERT -----------------",third}{"-------------DELETE------------------",fourth}{"-------------UPDATE------------------",fifth}");
                Console.WriteLine($"{"1 - Read Students",first}{"5 - Read Students Per Course",second}{"9 - Insert Students",third}{"13 - Delete Students",fourth}{"17 - Update Students"}");
                Console.WriteLine($"{"2 - Read Trainers",first}{"6 - Read Trainers Per Course",second}{"10 - Insert Trainers",third}{"14 - Delete Trainers",fourth}{"18 - Update Trainers"}");
                Console.WriteLine($"{"3 - Read Assigments",first}{"7 - Read Assigments Per Course",second}{"11 - Insert Assigments",third}{"15 - Delete Assigments",fourth}{"19 - Update Assigments"}");
                Console.WriteLine($"{"4 - Read Courses",first}{"8 - Read Assigments Per Student",second}{"12 - Insert Courses",third}{"16 - Delete Courses",fourth}{"20 - Update Courses"}");
               
               

                input = Console.ReadLine();
                switch (input)
                {
                    case "1": View.Students(db.Students, "All Students");break;
                    case "2": View.Trainers(db.Trainers, "All Trainers");break;
                    case "3": View.Assigments(db.Assigments, "All Assigments");break;
                    default:
                        Console.WriteLine("Wrong choice try again!");break;
                    
                }

            } while (input != "E" && input != "e");


            
            
        }
    }
}

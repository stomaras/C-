using PARTB.Models;
using PARTB.Models.CustomValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.StudentView
{
    public class PrintStudent : IPrintStudent
    {
        Helper helper = new Helper();
        public Student EnterStudentDetailsToCreate()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Enter Student Details:\n");

            Console.WriteLine("Enter Student First Name:\n");
            string firstName = helper.ValidName(Console.ReadLine());

            Console.WriteLine("Enter Student Last Name:\n");
            string lastName = helper.ValidName(Console.ReadLine());
        }

        public void PrintStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students:\n");
            foreach (var student in students)
            {
                Console.WriteLine($"\t\tStudent : with first name {student.FirstName}, with last name {student.LastName}, with date of birth {student.DateOfBirth}\n");
            }
            Console.ResetColor();
        }
    }
}

using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.StudentView
{
    public class PrintStudent : IPrintStudent
    {
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

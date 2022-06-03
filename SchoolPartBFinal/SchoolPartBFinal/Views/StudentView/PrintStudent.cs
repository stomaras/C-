using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Views.StudentView
{
    public class PrintStudent : IPrintStudent
    {
        public void PrintStudents(List<Student> students)
        {
            for (int i = 0; i <= students.Count-1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Student with first name {students[i].FirstName} with last name {students[i].LastName} ");
                Console.ResetColor();
            }
        }

        public void PrintAStudent(Student student)
        {
            Console.WriteLine("Print A Student");
            throw new NotImplementedException();
        }

        public void PrintStudentSuccessCreateMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            
        }

        public void PrintStudentSuccessUpdateMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintStudentFailureUpdateMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All Students :\n");
            for (int i = 0; i <= students.Count-1; i++)
            {
                Console.WriteLine($"\t\tStudent {{ with first name {students[i].FirstName}, with last name {students[i].LastName}, " +
                    $" with birth date {students[i].BirthDate}, with tuiton fees {students[i].TuitionFees} }}");
            }
            Console.ResetColor();
        }

        public void PrintAStudent(Student student)
        {
            Console.WriteLine("Print A Student");
            throw new NotImplementedException();
        }

        public void PrintStudentSuccessDeleteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
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

        public void PrintStudentFailureDeleteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

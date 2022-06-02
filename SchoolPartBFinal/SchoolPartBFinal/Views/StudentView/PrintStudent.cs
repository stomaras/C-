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
            Console.WriteLine("Print All Students");
            throw new NotImplementedException();
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
    }
}

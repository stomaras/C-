using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Views.StudentView
{
    public class PrintStudent : IPrintStudent
    {
        public void Print(Student student)
        {
            Console.WriteLine($"{"Id",-5}{"Name",-15}{"Score",-15}");
            Console.WriteLine($"{student.Id,-5}{student.Name,-15}{student.Score,-15}");
        }

        public void PrintStudents(List<Student> students)
        {
            Console.WriteLine($"{"Id",-5}{"Name",-15}{"Score",-15}");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id,-5}{student.Name,-15}{student.Score,-15}");
            }
        }

    }
}

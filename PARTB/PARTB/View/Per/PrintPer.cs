using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.Per
{
    public class PrintPer : IPrintPer
    {
        public void PrintAllStudentsPerCourse(List<Course> Courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------Students Per Course-------------------------");
            Console.WriteLine("Courses:\n");
            foreach (var course in Courses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\tCourse: with title {course.Title}, with type {course.Type}\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\t\t\tStudents:\n");
                foreach (var student in course.Students)
                {
                    
                    Console.WriteLine($"\t\t\t\t Student: {{ FullName: {student.FirstName} {student.LastName}}}\n");
                    
                }
                Console.ResetColor();
            }
        }

        public void PrintAllTrainersPerCourse(List<Trainer> Trainers)
        {
            throw new NotImplementedException("Print All Trainers Per Course");
        }
    }
}

using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.CourseView
{
    public class PrintCourse : IPrintCourse
    {
        public void PrintAllCourses(List<Course> Courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Courses:\n");
            foreach (var course in Courses)
            {
                Console.WriteLine($"\t\t Course with title {course.Title} , with type {course.Type} ,with start date {course.Start_Date} , with end date {course.End_Date}\n");
            }
            Console.ResetColor();

        }
    }
}

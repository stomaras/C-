using PARTB.Models;
using PARTB.Models.CustomValidations;
using PARTB.ObjectFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.CourseView
{
    public class PrintCourse : IPrintCourse
    {

        Helper helper = Factory.CreateHelperObject();
        public void EnterCourseDetailsToCreate(out (string title, string type, DateTime start_date, DateTime end_date) course, List<Course> Courses)
        {
            Console.WriteLine($"Enter Course Details :\n");
            Console.WriteLine($"Enter Course Title :\n");
            string title = Console.ReadLine();
            string Validtitle = helper.CheckValidTitle(title, Courses);
            Console.WriteLine(Validtitle);

            Console.WriteLine("Enter Course Type :\n");
            string type = Console.ReadLine();
            string ValidType = helper.CourseTypeValidation(type);
            Console.WriteLine(ValidType);

            Console.WriteLine("Enter Course Start Date : \n");
            Console.WriteLine("Enter Course Start Day : \n");
            string startDay = Console.ReadLine();
            int validStartDay = helper.CheckDay(startDay);


            Console.WriteLine("Enter Course Start Month :\n ");
            string startMonth = Console.ReadLine();
            int validStartMonth = helper.CheckStartMonth(startMonth);

            int startYear = DateTime.Now.Year + 1;
            

            DateTime start_date = new DateTime(startYear, validStartMonth, validStartDay);

            DateTime end_date = helper.InitializeEndDate(ValidType, start_date);
            

            course = (Validtitle.Length > 20 ? null : Validtitle ,ValidType, start_date, end_date);

        }

        public void EnterCourseDetailsToCreate(out (string title, string type, DateTime start_date, DateTime end_date) course)
        {
            throw new NotImplementedException();
        }

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

        public void SuccessCourseCreateMessage(Course course)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New Course Created Successfully with title {course.Title}, with type {course.Type}, with start date {course.Start_Date}, with end date {course.End_Date}:\n");
            Console.ResetColor();
        }
    }
}

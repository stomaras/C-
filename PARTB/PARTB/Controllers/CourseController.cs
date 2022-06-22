using PARTB.Database;
using PARTB.Models;
using PARTB.Models.CustomValidations;
using PARTB.ObjectFactory;
using PARTB.Repositories.CourseRepository;
using PARTB.View.CourseView;
using PARTB.View.ErrorMessages;
using PARTB.View.Per;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Controllers
{
    public class CourseController
    {
        private ApplicationContext db = new ApplicationContext();

        private CourseRepository courseRepository;
        HelperCourse helperCourse = Factory.CreateHelperCourseObject();

        public CourseController()
        {
            courseRepository = new CourseRepository(db);
        }

        public void ReadingCourses()
        {
            try
            {
                PrintCourse printCourse = new PrintCourse();
                var courses = courseRepository.GetAllCourses();
                
                printCourse.PrintAllCourses(courses);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
        public void ReadStudentsPerCourse()
        {
            try
            {
                PrintPer printPer = new PrintPer();
                var courses = courseRepository.GetAllCoursesWithStudents();
                printPer.PrintAllStudentsPerCourse(courses);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadTrainersPerCourse()
        {
            try
            {
                PrintPer printPer = new PrintPer();
                var courses = courseRepository.GetAllCoursesWithTrainers();
                printPer.PrintAllTrainersPerCourse(courses);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateCourses()
        {
            try
            {
                PrintCourse pr = new PrintCourse();
                (string title, string type, DateTime start_date, DateTime end_date) courseDetails = ("", "", new DateTime(), new DateTime());
                var courses = courseRepository.GetAllCourses();
                pr.EnterCourseDetailsToCreate(out courseDetails, courses);
                Course course = new Course()
                {
                    Title = courseDetails.title,
                    Type = courseDetails.type,
                    Start_Date = courseDetails.start_date,
                    End_Date = courseDetails.end_date
                };
                bool intializaionCondition = helperCourse.ProcessInsertion(course.Type,course.Title, courses);
                InsertCourseIntoDB(intializaionCondition, course);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void InsertCourseIntoDB(bool initializationCond, Course course)
        {
            PrintCourse pr = new PrintCourse();
            if (initializationCond)
            {
                courseRepository.AddCourse(course);
                pr.SuccessCourseCreateMessage(course);
            }
            else
            {
                ErrorMessage.CourseErrorInsertMessage(course);
            }
        }
    }
}

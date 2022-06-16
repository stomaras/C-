using PARTB.Database;
using PARTB.Repositories.CourseRepository;
using PARTB.View.CourseView;
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
    }
}

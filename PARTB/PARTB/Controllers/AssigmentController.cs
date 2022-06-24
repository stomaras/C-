using PARTB.Database;
using PARTB.Models;
using PARTB.Repositories.AssigmentRepository;
using PARTB.Repositories.CourseRepository;
using PARTB.View.AssigmentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Controllers
{
    public class AssigmentController
    {

        private ApplicationContext db = new ApplicationContext();

        private AssigmentRepository assigmentRepository;
        private CourseRepository courseRepository;

        public AssigmentController()
        {
            assigmentRepository = new AssigmentRepository(db);
            courseRepository = new CourseRepository(db);
        }


        public void CreateAssigments()
        {
            try
            {
                PrintAssigment printAssigment = new PrintAssigment();
                List<Course> Courses = courseRepository.GetAllCourses();
                int cid = printAssigment.EnterCourseIdToAddAssigment(Courses);
                (string tile, string description, DateTime subDateTime) assigmentDetails = ("", "", new DateTime());
                printAssigment.EnterAssigmentDetails(out assigmentDetails, cid, Courses);
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void ReadingAssigments()
        {
            try
            {
                PrintAssigment printAssigment = new PrintAssigment();
                var assigments = assigmentRepository.GetAllAssigments();
                printAssigment.PrintAssigments(assigments);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ErrorService()
        {
            Console.WriteLine("This input does not exists try again or Press E (or) e to exit !!!");
        }
    }
}

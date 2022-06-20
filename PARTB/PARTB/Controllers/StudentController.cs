using PARTB.Database;
using PARTB.Models;
using PARTB.Repositories;
using PARTB.Repositories.CourseRepository;
using PARTB.View.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Controllers
{
    public class StudentController
    {

        private ApplicationContext db = new ApplicationContext();

        private StudentRepository studentRepository;
        private CourseRepository courseRepository;

        public StudentController()
        {
            studentRepository = new StudentRepository(db);
            courseRepository = new CourseRepository(db);
        }

        public void ReadingStudents()
        {
            try
            {
                PrintStudent pr = new PrintStudent();
                var students = studentRepository.GetAllStudents();
                pr.PrintStudents(students);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateStudents()
        {
            try
            {
                PrintStudent pr = new PrintStudent();
                (string firstName, string lastName, DateTime BirthDate, int TuitionFees) studentDetails = ("", "", new DateTime(), 0);
                pr.EnterStudentDetailsToCreate(out studentDetails);
                List<int> courseIds = courseRepository.GetAllCoursesIds();
                int studentCourseId = pr.EnterCourseId(courseIds);
                Student student = new Student() { 
                    FirstName = studentDetails.firstName,
                    LastName = studentDetails.lastName,
                    DateOfBirth = studentDetails.BirthDate,
                    TuitionFees = studentDetails.TuitionFees,
                    CourseId = studentCourseId
                };
                studentRepository.Add(student);
                pr.SuccessCreateMessage(student);
                var students = studentRepository.GetAllStudentsWithProjects();
                pr.PrintStudents(students);
            }catch(Exception ex)
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

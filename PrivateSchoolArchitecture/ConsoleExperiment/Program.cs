using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MyDatabase;
using Repositories.Persistance;
using Repositories.Persistance.Repositories;

namespace ConsoleExperiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            StudentRepository studentRepository = new StudentRepository(db);
            CourseRepository courseRepository = new CourseRepository(db);
            GenericRepository<Student> genericStudentRepo = new GenericRepository<Student>(db); 
            GenericRepository<Course> genericCourseRepository = new GenericRepository<Course>(db);

            UnitOfWork SchoolUnit = new UnitOfWork(db);

            var studentsByDesc = studentRepository.GetStudentsByDescending();

            var students = genericStudentRepo.GetAll();

            var coursesWithStudents = courseRepository.GetAllCoursesWithStudents();

            var groups = SchoolUnit.Students.GetStudentsGroupedByCountry();

            foreach (var student in studentsByDesc)
            {
                Console.WriteLine($"Student name: {student.FirstName}");
            }

            Console.WriteLine("------------All Students-------------------");
            foreach (var stu in students)
            {
                Console.WriteLine($"Student {{ with first name : {stu.FirstName}, with last name : {stu.LastName}, with tuition fees {stu.TuitionFees} }}");
            }

            Console.WriteLine("-------------------All Students Per Course----------------------");
            foreach (var course in coursesWithStudents)
            {
                Console.WriteLine($"Course : {{ with title : {course.Title}, with stream {course.Stream} }}\n");

                foreach (var stu in course.Students)
                {
                    Console.WriteLine($"\t\t with student {stu.FirstName} , {stu.LastName}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------All Students Per Country-------------------------------");
            foreach (var group in groups)
            {
                Console.WriteLine($" {group.Key,15}: {group.Count()}");
            }


            
        }
    }
}

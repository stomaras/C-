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

            var studentsByDateOfBirth = SchoolUnit.Students.GetStudentsByDateOfBirth();

            var coursesWithStudents = SchoolUnit.Courses.GetAllCoursesWithStudents();

            var courseWithTrainers = SchoolUnit.Courses.GetAllCoursesWithTrainers();

            var courseWithAssigments = SchoolUnit.Courses.GetAllCoursesWithAssigments();


            var trainersByAscending = SchoolUnit.Trainers.GetTrainersByAscending();

            var sumOfTuitionFees = SchoolUnit.Students.SumOfTuitionFees(students);
            var minBirthDateOfStudent = SchoolUnit.Students.MinAgeOfSudents(students);

            var groups = SchoolUnit.Students.GetStudentsGroupedByCountry();

            //foreach (var student in studentsByDesc)
            //{
            //    Console.WriteLine($"Student name: {student.FirstName}");
            //}

            //Console.WriteLine("------------All Students-------------------");
            //foreach (var stu in students)
            //{
            //    Console.WriteLine($"Student {{ with first name : {stu.FirstName}, with last name : {stu.LastName}, with tuition fees {stu.TuitionFees} }}");
            //}

            //Console.WriteLine("-------------------All Students Per Course----------------------");
            //foreach (var course in coursesWithStudents)
            //{
            //    Console.WriteLine($"Course : {{ with title : {course.Title}, with stream {course.Stream} }}\n");

            //    foreach (var stu in course.Students)
            //    {
            //        Console.WriteLine($"\t\t with student {stu.FirstName} , {stu.LastName}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("------------------All Students Per Country-------------------------------");
            //foreach (var group in groups)
            //{
            //    Console.WriteLine($" {group.Key,15}: {group.Count()}");
            //}
            //Console.WriteLine(SchoolUnit.complete());

            //Console.WriteLine("----------------------All Trainers By Ascending----------------------------");
            //foreach (var trainer in trainersByAscending)
            //{
            //    Console.WriteLine($"{trainer.FirstName}, {trainer.LastName}");
            //}

            //Console.WriteLine("---------------------------All Students By Date Of Birh----------------------------");
            //foreach (var student in studentsByDateOfBirth)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} {student.DateOfBirth}");
            //}


            //Console.WriteLine("-----------------------------All Trainers Per Course----------------------------------");
            //foreach (var course in courseWithTrainers)
            //{
            //    Console.WriteLine($"Course : {{ with title : {course.Title}, with stream {course.Stream} }}\n");
            //    foreach (var trainer in course.Trainers)
            //    {
            //        Console.WriteLine($"\t\t with trainer {trainer.FirstName}, {trainer.LastName}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("------------------------All Assigments Per Course----------------------------------------");
            //foreach (var course in courseWithAssigments)
            //{
            //    Console.WriteLine($"Course : {{ with title : {course.Title}, with stream {course.Stream}}}\n");
            //    foreach (var assigment in course.Assigments)
            //    {
            //        Console.WriteLine($"\t\t with assigment {assigment.Description}, {assigment.SubDateTime}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("------------------------------All Courses Per Students IQueryable----------------------------------");
            //foreach (var course in courseWithStudentsWithIQueryable)
            //{
            //    Console.WriteLine($"Course : {{ with title : {course.Title}, with stream {course.Stream}}}");
            //    foreach (var student in course.Students)
            //    {
            //        Console.WriteLine($"\t\t with student : {{ {student.FirstName}, {student.LastName} }}");
                    
            //    }
            //}

            Console.WriteLine($"Sum Of Tuition Fees are : {sumOfTuitionFees}");
            Console.WriteLine($"Min Birth Date Of Student : {minBirthDateOfStudent}");


            
        }
    }
}

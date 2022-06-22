using PARTB.Models;
using PARTB.Models.CustomValidations;
using PARTB.ObjectFactory;
using PARTB.View.ErrorMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.StudentView
{
    public class PrintStudent : IPrintStudent
    {
        Helper helper = Factory.CreateHelperObject();
        public void EnterStudentDetailsToCreate(out (string firstName, string lastName, DateTime DateOfBirth, int TuitionFees) student)
        {
           

            Console.WriteLine("Enter Student Details:\n");

            Console.WriteLine("Enter Student First Name:\n");
            string firstName = helper.CheckValidFirstName(Console.ReadLine());

            Console.WriteLine("Enter Student Last Name:\n");
            string lastName = helper.CheckValidLastName(Console.ReadLine());

            
            Console.WriteLine("Enter Student Date Of Birth:\n");
            Console.WriteLine("Enter Student Day Of Birth");
            Console.ResetColor();

            int dayOfBirthString = helper.CheckDay(Console.ReadLine());
            int dayOfBirthInt = Convert.ToInt32(dayOfBirthString);

            
            Console.WriteLine("Enter Student Month Of Birth:\n");
      

            string monthOfBirthString = helper.CheckMonth(Console.ReadLine());
            int monthOfBirthInt = Convert.ToInt32(monthOfBirthString);

           
            Console.WriteLine("Enter Student Year Of Birth:\n");
            

            string yearOfBirth = helper.CheckYear(Console.ReadLine());
            int yearOfBirthInt = Convert.ToInt32(yearOfBirth);

            DateTime dateOfBirth = new DateTime(yearOfBirthInt, monthOfBirthInt, dayOfBirthInt);

           
            Console.WriteLine("Enter Student Tuition Fees:\n");
            

            int tuitionFees = helper.CheckTuitionFees(Console.ReadLine());


            
            Console.WriteLine("Enter Student Course Id :\n");
            

            student = (firstName, lastName, dateOfBirth, tuitionFees);
        }

        public int EnterCourseId(List<int> CourseIds)
        {

            int upperBound = CourseIds.Count;
            int lowerBound = CourseIds[0];
            Console.WriteLine("Enter Course Id To Register:\n");
            int courseId = helper.GetValidNumber(Console.ReadLine());
            bool isFound = false;
            while (!isFound)
            {
                foreach (var id in CourseIds)
                {
                    if (id == courseId)
                    {
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    break;
                }
                else
                {
                    ErrorMessage.InValidCourseIdRange(upperBound, lowerBound);
                    Console.WriteLine("Enter Course Id To Register:\n");
                    courseId = helper.GetValidNumber(Console.ReadLine());
                }
            }
            return courseId;
        }

        public void PrintStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students:\n");
            foreach (var student in students)
            {
                Console.WriteLine($"\t\tStudent : with first name {student.FirstName}, with last name {student.LastName}, with date of birth {student.DateOfBirth}\n");
            }
            Console.ResetColor();
        }

        public void SuccessCreateMessage(Student student)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New Student {{ with first name {student.FirstName} , with last name {student.LastName}, with date of birth {student.DateOfBirth}, with tuition fees {student.TuitionFees}, with course title {student.Course.Title}, with course type {student.Course.Type} created successdully }}");
            Console.ResetColor();
        }

        
    }
}

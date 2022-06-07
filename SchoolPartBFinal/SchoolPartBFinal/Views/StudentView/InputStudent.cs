using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPartBFinal.GeneralServices;
using SchoolPartBFinal.FactoryObjects;
using SchoolPartBFinal.Validations;

namespace SchoolPartBFinal.Views.StudentView
{
    public class InputStudent : IInputStudent
    {

        StringEvaluations stringEvaluation = Factory.StringEvaluation();
        Helper helper = Factory.CreateHelper();
        public Func<string, string> CheckIfStringContainsNumberOrSpecialCharacters { get; private set; }

        public Student EnterStudentDetailsToUpdate()
        {
            
            
            Console.WriteLine("Enter Student Id To Update:\n");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student First Name To Update:\n");
            string firstNameToUpdate = Console.ReadLine();
            string firstName = stringEvaluation.CheckIfStringContainsNumberOrSpecialCharacters(firstNameToUpdate);

            Console.WriteLine("Enter Student Last Name To Update:\n");
            string lastNameToUpdate = Console.ReadLine();
            string lastName = stringEvaluation.CheckIfStringContainsNumberOrSpecialCharacters(lastNameToUpdate);

            Console.WriteLine("Enter Student Year Of Birth To Update:\n");
            int year = helper.CheckYearType(Console.ReadLine());

            Console.WriteLine("Enter Student Month Of Birth To Update:\n");
            int month = helper.CheckMonth(Console.ReadLine());

            Console.WriteLine("Enter Student Day Of Birth To Update:\n");
            int day = helper.CheckDay(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);

            Console.WriteLine("Enter Student Tuition Fees To Update:\n");
            int tuitionFees = helper.CheckTuitionFees(Console.ReadLine());

            Student student = new Student(id, firstName, lastName, dateOfBirth, tuitionFees);

            return student;
        }

        public int EnterStudentIdToDelete()
        {
            Console.WriteLine("Enter Student Id To Delete:\n");
           
            int id = Convert.ToInt32(Console.ReadLine());
            
            return id;

            
        }

        public Student EnterStudentToCreate()
        {
            StringEvaluations stringEvaluation = new StringEvaluations();
            Console.WriteLine("Enter Student First Name:\n");
            string studentFirstName = Console.ReadLine();
            string firstName = stringEvaluation.CheckIfStringContainsNumberOrSpecialCharacters(studentFirstName);

            Console.WriteLine("Enter Student Last Name:\n");
            string studentLastName = Console.ReadLine();
            string lastName = stringEvaluation.CheckIfStringContainsNumberOrSpecialCharacters(studentLastName);

            Console.WriteLine("Enter Student Year Of Birth:\n");
            int year = helper.CheckYearType(Console.ReadLine());
            
            Console.WriteLine("Enter Student Month Of Birth:\n");
            int month = helper.CheckMonth(Console.ReadLine());

            Console.WriteLine("Enter Student Day Of Birth:\n");
            int day = helper.CheckDay(Console.ReadLine());

            Console.WriteLine("Enter Student Tuition Fees:\n");
            int tuitionFees = helper.CheckTuitionFees(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);  

            Student student = new Student(firstName, lastName, dateOfBirth, tuitionFees);

            return student;
        }

        public int EnterStudentIdToRead()
        {
            Console.WriteLine("Enter Student Id:\n");

            int studentId = Convert.ToInt32(Console.ReadLine());

            return studentId;
        }
    }
}

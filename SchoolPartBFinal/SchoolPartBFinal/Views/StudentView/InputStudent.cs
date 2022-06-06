using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPartBFinal.GeneralServices;
using SchoolPartBFinal.FactoryObjects;

namespace SchoolPartBFinal.Views.StudentView
{
    public class InputStudent : IInputStudent
    {

        StringEvaluations stringEvaluation = Factory.StringEvaluation();
        public Func<string, string> CheckIfStringContainsNumberOrSpecialCharacters { get; private set; }

        public Student EnterStudentDetailsToUpdate()
        {
            
            
            Console.WriteLine("Enter Student Id To Update:\n");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student First Name:\n");
            string firstNameToUpdate = Console.ReadLine();
            string firstName = stringEvaluation.CheckIfStringContainsNumberOrSpecialCharacters(firstNameToUpdate);

            Console.WriteLine("Enter Student Last Name:\n");
            string lastNameToUpdate = Console.ReadLine();
            string lastName = stringEvaluation.CheckIfStringContainsNumberOrSpecialCharacters(lastNameToUpdate);

            Student student = new Student(id,firstName,lastName);

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

            // todo method to check if student year of Birth is between 2004-1970
            Console.WriteLine("Enter Student Year Of Birth:\n");
            int year = Convert.ToInt32(Console.ReadLine());

            // todo method to check id student month of birth is integer and number between 1-12
            Console.WriteLine("Enter Student Month Of Birth:\n");
            int month = Convert.ToInt32(Console.ReadLine());

            // todo method to check if student day of birth is integer between 1-365
            Console.WriteLine("Enter Student Day Of Birth:\n");
            int day = Convert.ToInt32(Console.ReadLine());

            // todo method to check if student tuitionfees is integer 2100 or 2500 only!!!
            Console.WriteLine("Enter Student Tuition Fees:\n");
            int tuitionFees = Convert.ToInt32(Console.ReadLine());

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

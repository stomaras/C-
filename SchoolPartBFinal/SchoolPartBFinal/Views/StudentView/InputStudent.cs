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
            throw new NotImplementedException();

            return -1;
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

            Student student = new Student(firstName, lastName);
            
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

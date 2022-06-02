using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPartBFinal.GeneralServices;

namespace SchoolPartBFinal.Views.StudentView
{
    public class InputStudent : IInputStudent
    {
        public Func<string, string> CheckIfStringContainsNumberOrSpecialCharacters { get; private set; }

        public Student EnterStudentDetailsToUpdate()
        {
            

            Console.WriteLine("Enter Student First Name:\n");

            Console.WriteLine("Enter Student Last Name:\n");

            Student student = new Student();
            throw new NotImplementedException();

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
            string word = Console.ReadLine();
           
            string firstName = stringEvaluation.CheckIfStringContainsNumberOrSpecialCharacters(word);
            


            Console.WriteLine("Enter Student Last Name:\n");
            string lastName = Console.ReadLine();

            Student student = new Student(firstName, lastName);
            
            return student;
        }
    }
}

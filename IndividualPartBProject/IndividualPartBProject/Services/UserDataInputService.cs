using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualPartBProject.Models;
using IndividualPartBProject.Services;

namespace IndividualPartBProject.Services
{
    class UserDataInputService
    {

        public UserDataInputService()
        {

        }

        public static void Options()
        {
            Console.WriteLine("Private School Start:\n");
            Console.WriteLine("Press 1 To Enter Assigment Details:\n");
            Console.WriteLine("Press 2 To Enter Course Details:\n");
            Console.WriteLine("Press 3 To Enter Student Details:\n");
            Console.WriteLine("Press 4 To Enter Trainer Details:\n");
            Console.WriteLine("Press 0 To Exit The Program:\n");
        }

        public static Assigment EnterAssigmentDetails()
        {
            
            Assigment assigment = new Assigment();
            Console.WriteLine("Enter Assigment Title:\n");
            string title = Console.ReadLine();
            while (!assigment.CheckTitle(title))
            {
                Console.WriteLine("Enter Assigment Title must be something among ['Assigment 1', 'Assigment 2', 'Assigment 3', 'Assigment 4', 'Individual Part A', 'Individual Part B', 'Group Project']:\n");
                title = Console.ReadLine();
            }
            Console.WriteLine("Enter Assigment Description:\n");
            string description = Console.ReadLine();
            while (!assigment.CheckDescription(description))
            {
                Console.WriteLine("Enter Assigment Description must be something among ['Java Part Time', 'C# Part Time', 'Python Part Time', 'Javascript Part Time', 'Java Full Time', 'C# Full Time', 'Python Full Time', 'Javascript Full Time' ]");
                description = Console.ReadLine();
            }
            Console.WriteLine("Enter Assigment Submission DateTime:\n");
            Console.WriteLine("Enter Assigment Submission Day:\n");
            string candidateSubmissionDay  = Console.ReadLine();
            int subDay = assigment.CheckIfIsNumber(candidateSubmissionDay);
            int Day = assigment.SubmissionDay(subDay);
            Console.WriteLine("Enter Assigment Submission Month:\n");
            string candidateSubmissionMonth = Console.ReadLine();
            int subMonth = assigment.CheckIfIsNumber(candidateSubmissionMonth);
            int Month = assigment.SubmissionMonth(subMonth);
            Console.WriteLine("Enter Assigment Submission Year:\n");
            string candidateSubmissionYear = Console.ReadLine();
            int subYear = assigment.CheckIfIsNumber(candidateSubmissionYear);
            int Year = assigment.SubmissionYear(subYear);
            DateTime subDateTime = new DateTime(Year, Month, Day);
            Assigment assigmentObj = new Assigment(title, description, subDateTime);
            return assigmentObj;
        }
    }
}

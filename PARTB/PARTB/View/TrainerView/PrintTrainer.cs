using PARTB.Models;
using PARTB.Models.CustomValidations;
using PARTB.ObjectFactory;
using PARTB.View.ErrorMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.TrainerView
{
    public class PrintTrainer : IPrintTrainer
    {

        Helper helper = Factory.CreateHelperObject();
        public void EnterTrainerDetailsToCreate(out (string firstName, string lastName, string subject) trainer)
        {
            Console.WriteLine("Enter Trainer Details:\n");

            Console.WriteLine("Enter Trainer First Name:\n");
            string firstName = helper.CheckValidFirstName(Console.ReadLine());

            Console.WriteLine("Enter Trainer Last Name:\n");
            string lastName = helper.CheckValidLastName(Console.ReadLine());

            Console.WriteLine("Enter Trainer Subject:\n");
            string subject = helper.CheckSubject(Console.ReadLine());

            trainer = (firstName, lastName, subject);
        }

        public void PrintTrainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trainers:\n");
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"\t\tTrainer : with first name {trainer.FirstName}, with last name {trainer.LastName}, with subject {trainer.Subject}\n");
            }
            Console.ResetColor();
            
        }

        public int EnterCourseId(List<int> CourseIds)
        {

            int upperBound = CourseIds.Count;
            int lowerBound = CourseIds[0];
            Console.WriteLine("Enter Course Id for the trainer:\n");
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
                    Console.WriteLine("Enter Course Id for the trainer:\n");
                    courseId = helper.GetValidNumber(Console.ReadLine());
                }
            }
            return courseId;
        }

        public void SuccessCreateMessageTrainer(Trainer trainer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New Trainer {{ with first name {trainer.FirstName}, with last name {trainer.LastName}, with subject {trainer.Subject} , with course title to teach {trainer.Course.Title}, with course type to teach {trainer.Course.Type} }}");
            Console.ResetColor();
        }
    }
}

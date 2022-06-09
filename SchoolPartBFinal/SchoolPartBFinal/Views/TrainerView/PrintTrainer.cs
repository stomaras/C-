using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Views.TrainerView
{
    public class PrintTrainer : IPrintTrainer
    {
        public void PrintSuccessCreateTrainerMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintSuccessDeleteTrainerMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintSuccessUpdateTrainerMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintTrainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trainers:\n");
            foreach (var tr in trainers)
            {
                Console.WriteLine($"\t\tTrainer : {{ with First Name : {tr.FirstName}, with Last Name : {tr.LastName}, with Subject : {tr.Subject}}}");
            }
            Console.ResetColor();
        }

        public void PrintATrainer(Trainer trainer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Trainer {{ with first name :{trainer.FirstName} , with last name :{trainer.LastName}, with subject : {trainer.Subject}}}");
            Console.ResetColor();
        }

        public void CreateTrainerFirstName()
        {
            Console.WriteLine("Create Trainer First Name:\n");
        }

        public void CreateTrainerLastName()
        {
            Console.WriteLine("Create Trainer Last Name:\n");
        }

        public void CreateTrainerSubject()
        {
            Console.WriteLine("Create Trainer Subject:\n");
        }

        public void PrintTrainerFirstNameCannotBeNull()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First Name of a trainer cannot be empty try again:\n");
            Console.ResetColor();
        }

        public void PrintTrainerFirstNameCannotContainNumbersOrSpecialCharacters()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First Name of a trainer cannot contains numbers or special characters try again!:\n");
            Console.ResetColor();
        }

        

        public void PrintTrainerCannotBeLessThan2CharactersLongOrBiggerThan50CharactersLong()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First Name of a trainer cannot be less than 2 characters long or bigger than 50 characters long!:\n");
            Console.ResetColor();
        }

        public void PrintTrainerLastNameCannotContainNumbersOrSpecialCharacters()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Last Name of a trainer cannot contains numbers or special characters try again!:\n");
            Console.ResetColor();
        }

        public void PrintTrainerLastNameCannotBeLessThan2CharactersLongOrBiggerThan50CharactersLong()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Last Name of a trainer cannot be less than 2 characters long or bigger than 50 characters long!:\n");
            Console.ResetColor();
        }

        public void PrintTrainerLaastNameCannotBeNull()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Last Name of a trainer cannot be empty:\n");
            Console.ResetColor();
        }

        public void PrintSubjectCannotContainNumbersOrSpecialCharacters()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Subject of a trainer cannot be number or special character:\n");
            Console.ResetColor();
        }

        public void PrintSubjectInValidSubjectDetails()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Subject of a trainer can be << java (or) csharp (or) python (or) javascript:\n");
            Console.ResetColor();
        }

        public void PrintSubjectCannotBeNull()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Subject of a trainer cannot be null:\n");
            Console.ResetColor();
        }

        public void EnterTrainerIDToDelete()
        {
            Console.WriteLine("Enter trainer id to delete : \n");
        }

        public void PrintTrainerIDMustBeNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Trainer ID must be a number try again: \n");
            Console.ResetColor();
        }

        public void EnterTrainerID()
        {
            throw new NotImplementedException();
        }

        public void PrintFailureDeleteTrainerMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    
}

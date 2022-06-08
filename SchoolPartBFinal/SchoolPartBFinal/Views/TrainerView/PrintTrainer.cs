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
                Console.WriteLine(tr);
            }
            Console.ResetColor();
        }

        public void PrintATrainer(Trainer trainer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Trainer {{ with first name :{trainer.FirstName} , with last name :{trainer.LastName}, with subject : {trainer.Subject}}}");
            Console.ResetColor();
        }
    }
}

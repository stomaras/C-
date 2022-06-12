using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.TrainerView
{
    public class PrintTrainer : IPrintTrainer
    {
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
    }
}

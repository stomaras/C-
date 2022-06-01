using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Views.TrainerView
{
    public class PrintTrainer : IPrintTrainer
    {
        public void PrintTrainers(List<Trainer> trainers)
        {
            Console.WriteLine("Print All Trainers");
            throw new NotImplementedException();
        }

        public void Print(Trainer trainer)
        {
            Console.WriteLine("Print Trainer");
            throw new NotImplementedException();
        }
    }
}

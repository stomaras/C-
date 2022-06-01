using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ptolemeos.Entities;

namespace Ptolemeos.Views.TrainerView
{
    public interface IPrintTrainer
    {
        void Print(Trainer trainer);
        void PrintTrainers(List<Trainer> trainers);
    }
}

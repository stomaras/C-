using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Views.TrainerView
{
    public interface IPrintTrainer
    {

        void PrintATrainer(Trainer trainer);
        void PrintTrainers(List<Trainer> trainers);

        void PrintSuccessCreateTrainerMessage(string message);
        void PrintSuccessUpdateTrainerMessage(string message);
        void PrintSuccessDeleteTrainerMessage(string message);


    }
}

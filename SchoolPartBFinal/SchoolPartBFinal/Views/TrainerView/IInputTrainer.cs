using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Views.TrainerView
{
    public interface IInputTrainer
    {
        Trainer EnterTrainerToCreate();

        Trainer EnterTrainerToUpdate();

        int EnterTrainerIdToDelete();
    }
}

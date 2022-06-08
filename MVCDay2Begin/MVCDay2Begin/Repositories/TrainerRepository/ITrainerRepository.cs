using MVCDay2Begin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDay2Begin.Repositories.TrainerRepository
{
    public interface ITrainerRepository
    {
        List<Trainer> GetTrainers();

        Trainer GetById(int? id);

        void DeleteTrainer(Trainer trainer);
    }
}

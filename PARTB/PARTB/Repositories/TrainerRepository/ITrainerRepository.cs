using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories.TrainerRepository
{
    public interface ITrainerRepository
    {
        List<Trainer> GetAllTrainers();

        void AddTrainer(Trainer trainer);   
    }
}

using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.RepositoryServices.TrainerRepository
{
    public interface ITrainerRepository
    {
        string CreateTrainer(Trainer trainer);
        List<Trainer> GetAll();
        Trainer GetTrainerById(int id);
        Trainer DeleteTrainer(int id);
        Trainer UpdateTrainer(Trainer student);

        List<int> GetAllTrainerIds();
        
    }
}

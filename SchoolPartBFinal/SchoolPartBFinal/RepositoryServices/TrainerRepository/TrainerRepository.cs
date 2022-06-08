using SchoolPartBFinal.Database;
using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.RepositoryServices.TrainerRepository
{
    public class TrainerRepository : ITrainerRepository
    {
        public string CreateTrainer(Trainer trainer)
        {
            using (var db = new ApplicationContext())
            {
                
            }
            return "Create Trainer";
        }

        public Trainer DeleteTrainer(int id)
        {
            using (var db = new ApplicationContext())
            {

            }
            return null;
        }

        public List<Trainer> GetAll()
        {
            using (var db = new ApplicationContext())
            {

            }
            return null;
        }

        public List<int> GetAllTrainerIds()
        {
            using (var db = new ApplicationContext())
            {

            }
            return null;
        }

        public Trainer GetTrainerById(int id)
        {
            using (var db = new ApplicationContext())
            {

            }
            return null;
        }

        public Trainer UpdateTrainer(Trainer student)
        {
            using (var db = new ApplicationContext())
            {

            }
            return null;
        }
    }
}

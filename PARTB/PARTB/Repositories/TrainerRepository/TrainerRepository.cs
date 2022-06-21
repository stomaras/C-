using PARTB.Database;
using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories.TrainerRepository
{
    public class TrainerRepository : ITrainerRepository
    {
        private ApplicationContext db;

        public TrainerRepository(ApplicationContext context)
        {
            db = context;
        }

        public void AddTrainer(Trainer trainer)
        {
            if (trainer == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                db.Entry(trainer).State = EntityState.Added;
                db.SaveChanges();
            }
           
        }

        public List<Trainer> GetAllTrainers()
        {
            var trainers = db.Trainers.ToList();
            if (trainers == null)
            {
                throw new NotImplementedException("Trainers does not exists in db");
            }
            return trainers;
        }
    }
}

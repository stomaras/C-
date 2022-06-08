using MVCDay2Begin.Data;
using MVCDay2Begin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDay2Begin.Repositories.TrainerRepository
{
    public class TrainerRepository : ITrainerRepository
    {

        ApplicationContext db;

        public TrainerRepository(ApplicationContext context)
        {
            db = context;
        }

        public void DeleteTrainer(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Trainer GetById(int? id)
        {
            var trainer = db.Trainers.Find(id);
            return trainer;
        }

        public List<Trainer> GetTrainers()
        {
            return db.Trainers.ToList();
        }
    }
}
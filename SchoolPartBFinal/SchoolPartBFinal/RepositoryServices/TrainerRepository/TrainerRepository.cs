using SchoolPartBFinal.Database;
using SchoolPartBFinal.Entities;
using SchoolPartBFinal.FactoryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;

namespace SchoolPartBFinal.RepositoryServices.TrainerRepository
{
    public class TrainerRepository : ITrainerRepository
    {
        public IEnumerable<object> Trainers { get; private set; }

        public string CreateTrainer(Trainer trainer)
        {
            using (var db = new ApplicationContext())
            {
                var newFirstName = trainer.FirstName;
                var newLastName = trainer.LastName;
                var newSubject = trainer.Subject;
                db.Database.ExecuteSqlCommand("INSERT INTO Trainers VALUES(@FirstName, @LastName, @Subject)",
                    new SqlParameter("FirstName", newFirstName),
                    new SqlParameter("LastName", newLastName),
                    new SqlParameter("Subject", newSubject)
                );
            }
            string message = $"New Trainer with first name :{trainer.FirstName}, with last name: {trainer.LastName}, with subject: {trainer.Subject} created and added to database!!!";
            return message;
        }

        public Trainer DeleteTrainer(int id)
        {

            TrainerRepository trainerRepository = Factory.CreateTrainerRepository();
            var trainerToDelete = new Trainer()
            {
                Id = id
            };
            var deleteTrainer = trainerRepository.GetTrainerById(id);
            using (var db = new ApplicationContext())
            {
                var sql = @"DELETE [Trainers] FROM Trainers WHERE Id=@Id";
                db.Database.ExecuteSqlCommand(sql, new SqlParameter("@Id", id));

                db.SaveChanges();
            }

            return trainerToDelete;
        }

        public List<Trainer> GetAll()
        {
            List<Trainer> trainers = Factory.CreateListWithTrainers();
            using (var db = new ApplicationContext())
            {
                trainers = db.Trainers.SqlQuery("SELECT * FROM Trainers").ToList<Trainer>();
            }
            return trainers;
        }

        public List<int> GetAllTrainerIds()
        {
            List<int> trainerIDs = Factory.CreateListWithInts();
            using (ApplicationContext db = new ApplicationContext())
            {
                var Trainers = db.Trainers.ToList();

                foreach (var trainer in Trainers)
                {
                    trainerIDs.Add(trainer.Id);
                }
            }
            return trainerIDs;
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

        public bool CheckIfTrainerIdExists(List<int> TrainerIds, int TrainerId)
        {
            bool exists = false;
            for (int i = 0; i <= TrainerIds.Count - 1; i++)
            {

                if (TrainerIds[i] == TrainerId)
                {

                    exists = true;
                }
            }
            return exists;
        }
    }
}

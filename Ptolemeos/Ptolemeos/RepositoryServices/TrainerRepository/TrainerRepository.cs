using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.RepositoryServices.TrainerRepository
{
    public class TrainerRepository : ITrainerRepository
    {
        public void Add(Trainer trainer)
        {
            Console.WriteLine("Add Trainer to database");
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Console.WriteLine("Delete Trainer from database");
            throw new NotImplementedException();
        }

        public List<Trainer> Get(int id)
        {
            Console.WriteLine("Get Trainer from Database based on Id");
            throw new NotImplementedException();
        }

        public List<Trainer> GetAll()
        {
            Console.WriteLine("Read All Trainers from Database");
            throw new NotImplementedException();
        }

        public void Update(Trainer trainer)
        {
            Console.WriteLine("Update Trainer from Database");
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ptolemeos.Entities;
namespace Ptolemeos.RepositoryServices.TrainerRepository
{
    public interface ITrainerRepository
    {
        List<Trainer> GetAll();
        List<Trainer> Get(int id);
        void Add(Trainer trainer);
        void Update(Trainer trainer);
        void Delete(int id);
    }
}

using PARTB.Database;
using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories.AssigmentRepository
{
    public class AssigmentRepository : IAssigmentRepository
    {
        private ApplicationContext db;

        public AssigmentRepository(ApplicationContext context)
        {
            db = context;
        }

        public void AddAssigment(Assigment assigment)
        {
            db.Entry(assigment).State = EntityState.Added;
            db.SaveChanges();
        }

        public List<Assigment> GetAllAssigments()
        {
            var assigments = db.Assigments.ToList();
            return assigments;
        }
    }
}

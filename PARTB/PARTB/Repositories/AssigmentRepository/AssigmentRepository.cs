using PARTB.Database;
using PARTB.Models;
using System;
using System.Collections.Generic;
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
        public List<Assigment> GetAllAssigments()
        {
            var assigments = db.Assigments.ToList();
            return assigments;
        }
    }
}

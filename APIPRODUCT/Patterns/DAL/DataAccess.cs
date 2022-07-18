using MyDatabase;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DAL
{
    public class DataAccess : DbContext
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        public UnitOfWork superMarket;
        public DataAccess():base("Sindesmos")
        {
            superMarket = new UnitOfWork(db);
        }
    }
}

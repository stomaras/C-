using Entities;
using MyDatabase;
using MyDatabase.Initializers;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DAL
{
    public class DataAccessLayer:DbContext
    {
        public MyApplicationContext db = new MyApplicationContext();
        public UnitOfWork unitOfWork;

        public DataAccessLayer() : base("Sindesmos")
        {
            unitOfWork = new UnitOfWork(db);
        }  
    }
}


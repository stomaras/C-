using MyDatabase;
using Repositories.Core;
using Repositories.Core.Repositories;
using Repositories.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db;
        public IPlayerRepository Players { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            db = context;
            Players = new PlayerRepository(context);
        }

        public int Complete()
        {
            return db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

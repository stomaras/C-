using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Repositories
{
    public class ManagerRepository
    {
        ApplicationContext db;

        public ManagerRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Manager> GetAll()
        {
            return db.Managers.ToList();
        }
    }
}
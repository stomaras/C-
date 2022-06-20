using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication8.Models;
using WebApplication8.MyDatabase;
using System.Data.Entity;

namespace WebApplication8.Repositories
{
    public class ManagerRepository
    {
        private ApplicationContext db = new ApplicationContext();

        public ManagerRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Manager> GetAll()
        {
            var managers = db.Managers.ToList();
            return managers;
        }

        public List<Manager> GetAllWithEmployees()
        {
            var managersWithEmployees = db.Managers.Include(x => x.Employees).ToList();
            return managersWithEmployees;
        }

        public Manager GetById(int? id)
        {
            var manager = db.Managers.Find(id);
            
            return manager;
        }

        public Manager GetByIdWithEmployees(int? id)
        {
            var managersWithEmployees = db.Managers.Include(x => x.Employees).ToList();
            var manager = managersWithEmployees.Find(x => x.Id == id);
            return manager;
        }

    }
}
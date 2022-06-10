using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Repositories
{
    public class ProjectRepository
    {

        ApplicationContext db;

        public ProjectRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Project> GetAll()
        {
            return db.Projects.ToList();
        }

        

        public List<Project> GetAllWithEmployees()
        {
            return db.Projects.Include(x=>x.Employees).ToList();
        }

        public Project GetById(int? id)
        {
            var project = db.Projects.Find(id);
            return project;
        }

        public Project GetByIdWithEmployee(int? id)
        {
            var projects = GetAllWithEmployees();

            var pro = projects.Find(x=>x.Id == id);
            return pro;
        }

        public void Delete(Project pro)
        {
            db.Entry(pro).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Add(Project pro)
        {
            db.Entry(pro).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Project pro) // new Employee(){name="NewName"
        {
            // single responsiblity and seperaton of concerns
            db.Entry(pro).State = EntityState.Modified;
            db.SaveChanges();
            // ask sql server : do you have someone employee with id=55??
            
        }
    }
}
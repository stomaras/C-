using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication8.Models;
using WebApplication8.MyDatabase;

namespace WebApplication8.Repositories
{
    public class ProjectRepository
    {
        private ApplicationContext db;

        public ProjectRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Project> GetAll()
        {
            var projects = db.Projects.ToList();
            return projects;
        }

        public List<Project> GetAllWithEmployees()
        {
            var projectsWithEmployees = db.Projects.Include(x => x.Employees).ToList();
            return projectsWithEmployees;
        }

        public Project GetById(int? id)
        {
            var project = db.Projects.Find(id);
            return project;
        }

        public Project GetByIdWithProjects(int? id)
        {
            var projectsWithEmployees = db.Projects.Include(x => x.Employees).ToList();
            var projectsWithEmployeesForAnId = projectsWithEmployees.Find(x => x.Id == id);
            return projectsWithEmployeesForAnId;
        }

        public void Add(Project pro)
        {
            db.Entry(pro).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Project pro)
        {
            db.Entry(pro).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Project pro)
        {
            db.Entry(pro).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}